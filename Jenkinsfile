pipeline {
    agent any

    stages {
        // Stage 1: Checkout the Source Code
        stage('Checkout') {
            steps {
                echo 'Checking out the source code...'
            }
        }
        
        // Stage 2: Build the Project
        stage('Build') {
            steps {
                echo 'Building the project...'
            }
        }
        
        // Stage 3: Run Unit Tests
        stage('Test') {
            steps {
                echo 'Running unit tests...'
            }
        }
    }
    
    // Post-build actions
    post {
        always {
            echo 'Post-build actions...'
        }
    }
}
