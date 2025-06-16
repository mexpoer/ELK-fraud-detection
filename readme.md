# ELK Fraud Detection Internship Project

This repository contains the infrastructure and configurations for a monitoring and anomaly (fraud) detection system using the ELK stack, Grafana, and Prometheus.  
Developed as part of a one-month internship at a bank.

## Stack

- **Elasticsearch:** Log and metric storage
- **Logstash:** Log processing pipelines
- **Kibana:** Log search, dashboards, and visualizations
- **Prometheus:** Metrics collection and alerting
- **Grafana:** Unified dashboards and visualization

## Usage

1. Clone the repository:
   ```
   git clone https://github.com/mexpoer/ELK-fraud-detection.git
   cd ELK-fraud-detection
   ```
2. Start the stack with Docker Compose:
   ```
   docker-compose up -d
   ```
3. Access the services:
   - Kibana: [http://localhost:5601](http://localhost:5601)
   - Grafana: [http://localhost:3000](http://localhost:3000)
   - Prometheus: [http://localhost:9090](http://localhost:9090)

## Project Goals

- Aggregate and monitor logs from banking applications.
- Detect anomalies (potential fraud) using AI/ML and alerting.
- Visualize trends and incidents in Grafana/Kibana.
