AI-Powered English Proficiency App

🚀 Overview

This project is an AI-powered English proficiency app designed to help users improve their English skills through interactive lessons, speech analysis, and gamification. The platform consists of a frontend user interface, an admin portal, and a backend with AI-powered services.

📌 Tech Stack

Frontend (User & Admin UI)

Framework: Angular (Standalone Components)

Features: UI/UX optimized for educational apps with gamification elements

Backend (Microservices Architecture)

Core Business Logic: .NET 8 Web API (Clean Architecture)

AI Processing: Golang (Speech & NLP Services)

Authentication & Authorization: ASP.NET Core with JWT, OAuth2

AI Services

Speech Recognition: Azure AI (Speech-to-Text)

NLP: OpenAI GPT for grammar analysis and feedback

Database & Storage

Structured Data: PostgreSQL

Caching: Redis

Audio Storage: MinIO

Infrastructure & Deployment

API Gateway: Kong API Gateway

Messaging System: Kafka (Async AI Processing)

CI/CD: Azure DevOps Pipelines (Terraform + Ansible + Docker)

Hosting & Orchestration: Azure VM (Future: Kubernetes)

🎯 Features

📝 Interactive Lessons & Exercises

🎙️ Real-time Speech Analysis

🔥 Gamified Learning Experience

📊 Admin Dashboard for Managing Content & Users

🌍 Deployment Workflow

Infrastructure Provisioning: Terraform (Azure Resources)

Configuration Management: Ansible (Server Setup)

CI/CD Pipeline: Azure DevOps (Build & Deploy)

Containerized Services: Docker (Backend & AI Services)

🔧 Setup & Run Locally

Prerequisites

Node.js & Angular CLI (Frontend)

.NET 8 SDK (Backend API)

PostgreSQL & Redis

MinIO for object storage

Docker (Optional for local containers)

Run the Project

# Clone the repository
git clone https://github.com/your-repo.git
cd your-repo

# Start Frontend (Angular)
cd frontend
npm install
ng serve

# Start Backend (ASP.NET Core API)
cd backend
dotnet restore
dotnet run

# Start AI Services (Golang + Docker)
docker-compose up -d

📖 Roadmap



🛠️ Contributing

We welcome contributions! Please follow the contribution guidelines.

📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
