FROM gitpod/workspace-full
USER root

# Install dotnet core 2.2
# RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb &&
#    dpkg -i packages-microsoft-prod.deb && rm -rf packages-microsoft-prod.deb && \
#    add-apt-repository universe && \
#    apt-get update && apt-get -y -o APT::Install-Suggests="true" install dotnet-sdk-2.2 && \
#    apt -y clean;

# Install dotnet core 3.1
#RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb && \
#    dpkg -i packages-microsoft-prod.deb && rm -rf packages-microsoft-prod.deb && \
#    add-apt-repository universe && \
#    apt-get update && apt-get -y -o APT::Install-Suggests="true" install dotnet-sdk-3.1 && \
#    rm -rf /var/lib/apt/lists/*;

# USER gitpod

# RUN npm install -y -g @angular/cli
