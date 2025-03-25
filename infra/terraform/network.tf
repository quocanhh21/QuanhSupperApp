resource "azurerm_resource_group" "networking_rg" {
  name     = "NetworkingRG"
  location = "East US"
}

resource "azurerm_virtual_network" "main_vnet" {
  name                = "main-vnet"
  location            = azurerm_resource_group.networking_rg.location
  resource_group_name = azurerm_resource_group.networking_rg.name
  address_space       = ["10.0.0.0/16"]
}

