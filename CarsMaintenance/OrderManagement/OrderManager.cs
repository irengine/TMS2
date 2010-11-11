using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.OrderManagement
{
    public class OrderManager
    {
        // 库存 1000
        // 外借 2000
        public static string ACCOUNT_STORAGE = "1000";
        public static string ACCOUNT_OUT = "2000";
        public static string ACCOUNT_PRESCRAP = "3000";
        public static string ACCOUNT_SCRAP = "4000";
        public static string ACCOUNT_REPAIR = "5000";


        public static void Lend(OutboundOrder order, OutboundOrderDetail item)
        {
            // for inventory and inventory history
            // query item.Tool.ToolInventory
            ToolInventory inventory = item.Tool.ToolInventory;
            inventory.Quantity -= item.Quantity;
            inventory.OutQuantity += item.Quantity;

            ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
            inventoryHistory.Account = ACCOUNT_STORAGE;
            inventoryHistory.OutboundOrder = order;
            inventoryHistory.OutboundOrderDetail = item;
            inventoryHistory.Customer = order.Customer;
            inventoryHistory.ToolInventoryHistoryDate = item.OutboundDate;
            inventoryHistory.Tool = item.Tool;
            inventoryHistory.Quantity = -1 * item.Quantity;
            inventoryHistory.UnitPrice = item.UnitPrice;

            inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
            inventoryHistory.Account = ACCOUNT_OUT;
            inventoryHistory.OutboundOrder = order;
            inventoryHistory.OutboundOrderDetail = item;
            inventoryHistory.Customer = order.Customer;
            inventoryHistory.ToolInventoryHistoryDate = item.OutboundDate;
            inventoryHistory.Tool = item.Tool;
            inventoryHistory.Quantity = item.Quantity;
            inventoryHistory.UnitPrice = item.UnitPrice;
        }

        public static void Return(InboundOrder order, InboundOrderDetail item)
        {
            // for inventory and inventory history
            ToolInventory inventory = item.Tool.ToolInventory;
            inventory.Quantity += item.Quantity + item.TransferQuantity;
            inventory.OutQuantity -= item.Quantity + item.TransferQuantity + item.PrescrapQuantity;
            inventory.PrescrapQuantity += item.PrescrapQuantity;

            ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
            inventoryHistory.Account = ACCOUNT_STORAGE;
            inventoryHistory.OutboundOrder = order.OutboundOrder;
            inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
            inventoryHistory.InboundOrder = order;
            inventoryHistory.InboundOrderDetail = item;
            inventoryHistory.Customer = order.Customer;
            inventoryHistory.ToolInventoryHistoryDate = item.InboundDate;
            inventoryHistory.Tool = item.Tool;
            inventoryHistory.Quantity = item.Quantity + item.TransferQuantity;
            inventoryHistory.UnitPrice = item.UnitPrice;

            inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
            inventoryHistory.Account = ACCOUNT_OUT;
            inventoryHistory.OutboundOrder = order.OutboundOrder;
            inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
            inventoryHistory.InboundOrder = order;
            inventoryHistory.InboundOrderDetail = item;
            inventoryHistory.Customer = order.Customer;
            inventoryHistory.ToolInventoryHistoryDate = item.InboundDate;
            inventoryHistory.Tool = item.Tool;
            inventoryHistory.Quantity = -1 * (item.Quantity + item.TransferQuantity + item.PrescrapQuantity);
            inventoryHistory.UnitPrice = item.UnitPrice;

            inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
            inventoryHistory.Account = ACCOUNT_PRESCRAP;
            inventoryHistory.OutboundOrder = order.OutboundOrder;
            inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
            inventoryHistory.InboundOrder = order;
            inventoryHistory.InboundOrderDetail = item;
            inventoryHistory.Customer = order.Customer;
            inventoryHistory.ToolInventoryHistoryDate = item.InboundDate;
            inventoryHistory.Tool = item.Tool;
            inventoryHistory.Quantity = item.PrescrapQuantity;
            inventoryHistory.UnitPrice = item.UnitPrice;
        }

        public static void Scrap(ScrapOrder order, ScrapOrderDetail item)
        {
            if (item.ScrapOrderDetailID == 0)
            {
                ToolInventory inventory = item.Tool.ToolInventory;
                
                // Update unitprice:
                inventory.UnitPrice = (inventory.UnitPrice * inventory.Quantity - item.UnitPrice * item.ScrapQuantity) / (inventory.Quantity - item.ScrapQuantity);

                inventory.Quantity -= item.ScrapQuantity;
                inventory.ScrapQuantity += item.ScrapQuantity;

                ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_STORAGE;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = -1 * item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_SCRAP;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;
            }
            else
            {
                ToolInventory inventory = item.Tool.ToolInventory;

                // Update unitprice:
                inventory.UnitPrice = (inventory.UnitPrice * inventory.Quantity - item.UnitPrice * item.ScrapQuantity) / (inventory.Quantity - item.ScrapQuantity);

                inventory.PrescrapQuantity -= item.Quantity + item.RepairingQuantity + item.ScrapQuantity;
                inventory.Quantity += item.Quantity;
                inventory.RepairingQuantity += item.RepairingQuantity;
                inventory.ScrapQuantity += item.ScrapQuantity;

                ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_PRESCRAP;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = -1 * (item.Quantity + item.RepairingQuantity + item.ScrapQuantity);
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_STORAGE;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.Quantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_REPAIR;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.RepairingQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_SCRAP;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.ScrapOrder = order;
                inventoryHistory.ScrapOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.ScrapDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;
            }
        }

        public static void Repair(RepairOrder order, RepairOrderDetail item)
        {
            if (item.RepairOrderDetailID == 0)
            {
                ToolInventory inventory = item.Tool.ToolInventory;

                // Update unitprice:
                inventory.UnitPrice = (inventory.UnitPrice * inventory.Quantity - item.UnitPrice * item.ScrapQuantity) / (inventory.Quantity - item.ScrapQuantity);

                inventory.Quantity -= item.ScrapQuantity;
                inventory.ScrapQuantity += item.ScrapQuantity;

                ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_STORAGE;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = -1 * item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_SCRAP;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_REPAIR;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = -1 * item.RepairingQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_REPAIR;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.RepairingQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;
            }
            else
            {
                ToolInventory inventory = item.Tool.ToolInventory;

                // Update unitprice:
                inventory.UnitPrice = (inventory.UnitPrice * inventory.Quantity - item.UnitPrice * item.ScrapQuantity) / (inventory.Quantity - item.ScrapQuantity);

                inventory.Quantity += item.Quantity;
                inventory.RepairingQuantity -= item.RepairingQuantity;
                inventory.ScrapQuantity += item.ScrapQuantity;

                ToolInventoryHistory inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_STORAGE;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.Quantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_REPAIR;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = -1 * item.RepairingQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;

                inventoryHistory = SystemHelper.TMSContext.ToolInventoryHistories.CreateObject();
                inventoryHistory.Account = ACCOUNT_SCRAP;
                inventoryHistory.OutboundOrder = order.OutboundOrder;
                inventoryHistory.OutboundOrderDetail = item.OutboundOrderDetail;
                inventoryHistory.RepairOrder = order;
                inventoryHistory.RepairOrderDetail = item;
                inventoryHistory.Customer = order.Customer;
                inventoryHistory.ToolInventoryHistoryDate = item.RepairDate;
                inventoryHistory.Tool = item.Tool;
                inventoryHistory.Quantity = item.ScrapQuantity;
                inventoryHistory.UnitPrice = item.UnitPrice;
            }
        }
            
    }
}
