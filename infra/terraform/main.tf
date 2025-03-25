terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~>3.0"
    }
  }

  backend "azurerm" {
    resource_group_name  = "TerraformStateRG"
    storage_account_name = "terraformquanh123"
    container_name       = "terraform-state"
    key                  = "quanhsupperapp.terraform.tfstate"
  }
}

provider "azurerm" {
  features {}
}
