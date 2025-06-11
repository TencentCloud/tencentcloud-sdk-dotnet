/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gs.V20191118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gs.V20191118.Models;

   public class GsClient : AbstractClient{

       private const string endpoint = "gs.tencentcloudapi.com";
       private const string version = "2019-11-18";
       private const string sdkVersion = "SDK_NET_3.0.1258";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 备份云手机数据到指定存储，支持 COS 和兼容 AWS S3 协议的对象存储服务。如果是备份到 COS 时，会使用公网流量，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="BackUpAndroidInstanceToStorageRequest"/></param>
        /// <returns><see cref="BackUpAndroidInstanceToStorageResponse"/></returns>
        public Task<BackUpAndroidInstanceToStorageResponse> BackUpAndroidInstanceToStorage(BackUpAndroidInstanceToStorageRequest req)
        {
            return InternalRequestAsync<BackUpAndroidInstanceToStorageResponse>(req, "BackUpAndroidInstanceToStorage");
        }

        /// <summary>
        /// 备份云手机数据到指定存储，支持 COS 和兼容 AWS S3 协议的对象存储服务。如果是备份到 COS 时，会使用公网流量，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="BackUpAndroidInstanceToStorageRequest"/></param>
        /// <returns><see cref="BackUpAndroidInstanceToStorageResponse"/></returns>
        public BackUpAndroidInstanceToStorageResponse BackUpAndroidInstanceToStorageSync(BackUpAndroidInstanceToStorageRequest req)
        {
            return InternalRequestAsync<BackUpAndroidInstanceToStorageResponse>(req, "BackUpAndroidInstanceToStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量清理安卓实例应用数据
        /// </summary>
        /// <param name="req"><see cref="CleanAndroidInstancesAppDataRequest"/></param>
        /// <returns><see cref="CleanAndroidInstancesAppDataResponse"/></returns>
        public Task<CleanAndroidInstancesAppDataResponse> CleanAndroidInstancesAppData(CleanAndroidInstancesAppDataRequest req)
        {
            return InternalRequestAsync<CleanAndroidInstancesAppDataResponse>(req, "CleanAndroidInstancesAppData");
        }

        /// <summary>
        /// 批量清理安卓实例应用数据
        /// </summary>
        /// <param name="req"><see cref="CleanAndroidInstancesAppDataRequest"/></param>
        /// <returns><see cref="CleanAndroidInstancesAppDataResponse"/></returns>
        public CleanAndroidInstancesAppDataResponse CleanAndroidInstancesAppDataSync(CleanAndroidInstancesAppDataRequest req)
        {
            return InternalRequestAsync<CleanAndroidInstancesAppDataResponse>(req, "CleanAndroidInstancesAppData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 连接安卓实例
        /// </summary>
        /// <param name="req"><see cref="ConnectAndroidInstanceRequest"/></param>
        /// <returns><see cref="ConnectAndroidInstanceResponse"/></returns>
        public Task<ConnectAndroidInstanceResponse> ConnectAndroidInstance(ConnectAndroidInstanceRequest req)
        {
            return InternalRequestAsync<ConnectAndroidInstanceResponse>(req, "ConnectAndroidInstance");
        }

        /// <summary>
        /// 连接安卓实例
        /// </summary>
        /// <param name="req"><see cref="ConnectAndroidInstanceRequest"/></param>
        /// <returns><see cref="ConnectAndroidInstanceResponse"/></returns>
        public ConnectAndroidInstanceResponse ConnectAndroidInstanceSync(ConnectAndroidInstanceRequest req)
        {
            return InternalRequestAsync<ConnectAndroidInstanceResponse>(req, "ConnectAndroidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制安卓实例：
        /// 1. 排除和包含文件只能指定 /data 下的文件，不指定时复制整个 /data 目录
        /// 2. 源实例和目的实例必须在同一区域
        /// 3. 复制时，源实例和目的实例都会停机，复制完后实例会自动启动
        /// 4. 复制时会产生大量内网流量，请限制并发
        /// </summary>
        /// <param name="req"><see cref="CopyAndroidInstanceRequest"/></param>
        /// <returns><see cref="CopyAndroidInstanceResponse"/></returns>
        public Task<CopyAndroidInstanceResponse> CopyAndroidInstance(CopyAndroidInstanceRequest req)
        {
            return InternalRequestAsync<CopyAndroidInstanceResponse>(req, "CopyAndroidInstance");
        }

        /// <summary>
        /// 复制安卓实例：
        /// 1. 排除和包含文件只能指定 /data 下的文件，不指定时复制整个 /data 目录
        /// 2. 源实例和目的实例必须在同一区域
        /// 3. 复制时，源实例和目的实例都会停机，复制完后实例会自动启动
        /// 4. 复制时会产生大量内网流量，请限制并发
        /// </summary>
        /// <param name="req"><see cref="CopyAndroidInstanceRequest"/></param>
        /// <returns><see cref="CopyAndroidInstanceResponse"/></returns>
        public CopyAndroidInstanceResponse CopyAndroidInstanceSync(CopyAndroidInstanceRequest req)
        {
            return InternalRequestAsync<CopyAndroidInstanceResponse>(req, "CopyAndroidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓应用
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidAppRequest"/></param>
        /// <returns><see cref="CreateAndroidAppResponse"/></returns>
        public Task<CreateAndroidAppResponse> CreateAndroidApp(CreateAndroidAppRequest req)
        {
            return InternalRequestAsync<CreateAndroidAppResponse>(req, "CreateAndroidApp");
        }

        /// <summary>
        /// 创建安卓应用
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidAppRequest"/></param>
        /// <returns><see cref="CreateAndroidAppResponse"/></returns>
        public CreateAndroidAppResponse CreateAndroidAppSync(CreateAndroidAppRequest req)
        {
            return InternalRequestAsync<CreateAndroidAppResponse>(req, "CreateAndroidApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidAppVersionRequest"/></param>
        /// <returns><see cref="CreateAndroidAppVersionResponse"/></returns>
        public Task<CreateAndroidAppVersionResponse> CreateAndroidAppVersion(CreateAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<CreateAndroidAppVersionResponse>(req, "CreateAndroidAppVersion");
        }

        /// <summary>
        /// 创建安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidAppVersionRequest"/></param>
        /// <returns><see cref="CreateAndroidAppVersionResponse"/></returns>
        public CreateAndroidAppVersionResponse CreateAndroidAppVersionSync(CreateAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<CreateAndroidAppVersionResponse>(req, "CreateAndroidAppVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云手机实例 ADB 连接信息，请将返回结果的 PrivateKey 字段保存为 pem 文件，并将 pem 文件权限设置为 600，再参考返回结果的 ConnectCommand 使用 adb 连接实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceADBRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceADBResponse"/></returns>
        public Task<CreateAndroidInstanceADBResponse> CreateAndroidInstanceADB(CreateAndroidInstanceADBRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceADBResponse>(req, "CreateAndroidInstanceADB");
        }

        /// <summary>
        /// 创建云手机实例 ADB 连接信息，请将返回结果的 PrivateKey 字段保存为 pem 文件，并将 pem 文件权限设置为 600，再参考返回结果的 ConnectCommand 使用 adb 连接实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceADBRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceADBResponse"/></returns>
        public CreateAndroidInstanceADBResponse CreateAndroidInstanceADBSync(CreateAndroidInstanceADBRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceADBResponse>(req, "CreateAndroidInstanceADB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用指定的安卓实例创建镜像，创建镜像时指定的实例会关机，镜像创建完成后实例会自动开机。当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像创建完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceImageResponse"/></returns>
        public Task<CreateAndroidInstanceImageResponse> CreateAndroidInstanceImage(CreateAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceImageResponse>(req, "CreateAndroidInstanceImage");
        }

        /// <summary>
        /// 使用指定的安卓实例创建镜像，创建镜像时指定的实例会关机，镜像创建完成后实例会自动开机。当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像创建完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceImageResponse"/></returns>
        public CreateAndroidInstanceImageResponse CreateAndroidInstanceImageSync(CreateAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceImageResponse>(req, "CreateAndroidInstanceImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceLabelRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceLabelResponse"/></returns>
        public Task<CreateAndroidInstanceLabelResponse> CreateAndroidInstanceLabel(CreateAndroidInstanceLabelRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceLabelResponse>(req, "CreateAndroidInstanceLabel");
        }

        /// <summary>
        /// 创建安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceLabelRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceLabelResponse"/></returns>
        public CreateAndroidInstanceLabelResponse CreateAndroidInstanceLabelSync(CreateAndroidInstanceLabelRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceLabelResponse>(req, "CreateAndroidInstanceLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓实例 SSH 连接信息，请将返回结果的 PrivateKey 字段保存为 pem 文件，并将 pem 文件权限设置为 600，再参考返回结果的 ConnectCommand 使用 ssh 连接实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceSSHRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceSSHResponse"/></returns>
        public Task<CreateAndroidInstanceSSHResponse> CreateAndroidInstanceSSH(CreateAndroidInstanceSSHRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceSSHResponse>(req, "CreateAndroidInstanceSSH");
        }

        /// <summary>
        /// 创建安卓实例 SSH 连接信息，请将返回结果的 PrivateKey 字段保存为 pem 文件，并将 pem 文件权限设置为 600，再参考返回结果的 ConnectCommand 使用 ssh 连接实例。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceSSHRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceSSHResponse"/></returns>
        public CreateAndroidInstanceSSHResponse CreateAndroidInstanceSSHSync(CreateAndroidInstanceSSHRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceSSHResponse>(req, "CreateAndroidInstanceSSH")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓实例 WebShell 连接信息，返回的 ConnectUrl 可通过浏览器直接打开访问，链接有效期 1 小时，链接打开后可持续使用。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceWebShellRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceWebShellResponse"/></returns>
        public Task<CreateAndroidInstanceWebShellResponse> CreateAndroidInstanceWebShell(CreateAndroidInstanceWebShellRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceWebShellResponse>(req, "CreateAndroidInstanceWebShell");
        }

        /// <summary>
        /// 创建安卓实例 WebShell 连接信息，返回的 ConnectUrl 可通过浏览器直接打开访问，链接有效期 1 小时，链接打开后可持续使用。
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstanceWebShellRequest"/></param>
        /// <returns><see cref="CreateAndroidInstanceWebShellResponse"/></returns>
        public CreateAndroidInstanceWebShellResponse CreateAndroidInstanceWebShellSync(CreateAndroidInstanceWebShellRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstanceWebShellResponse>(req, "CreateAndroidInstanceWebShell")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安卓实例
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstancesRequest"/></param>
        /// <returns><see cref="CreateAndroidInstancesResponse"/></returns>
        public Task<CreateAndroidInstancesResponse> CreateAndroidInstances(CreateAndroidInstancesRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstancesResponse>(req, "CreateAndroidInstances");
        }

        /// <summary>
        /// 创建安卓实例
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstancesRequest"/></param>
        /// <returns><see cref="CreateAndroidInstancesResponse"/></returns>
        public CreateAndroidInstancesResponse CreateAndroidInstancesSync(CreateAndroidInstancesRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstancesResponse>(req, "CreateAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安卓实例截图
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstancesScreenshotRequest"/></param>
        /// <returns><see cref="CreateAndroidInstancesScreenshotResponse"/></returns>
        public Task<CreateAndroidInstancesScreenshotResponse> CreateAndroidInstancesScreenshot(CreateAndroidInstancesScreenshotRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstancesScreenshotResponse>(req, "CreateAndroidInstancesScreenshot");
        }

        /// <summary>
        /// 安卓实例截图
        /// </summary>
        /// <param name="req"><see cref="CreateAndroidInstancesScreenshotRequest"/></param>
        /// <returns><see cref="CreateAndroidInstancesScreenshotResponse"/></returns>
        public CreateAndroidInstancesScreenshotResponse CreateAndroidInstancesScreenshotSync(CreateAndroidInstancesScreenshotRequest req)
        {
            return InternalRequestAsync<CreateAndroidInstancesScreenshotResponse>(req, "CreateAndroidInstancesScreenshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建 Cos 临时密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosCredentialRequest"/></param>
        /// <returns><see cref="CreateCosCredentialResponse"/></returns>
        public Task<CreateCosCredentialResponse> CreateCosCredential(CreateCosCredentialRequest req)
        {
            return InternalRequestAsync<CreateCosCredentialResponse>(req, "CreateCosCredential");
        }

        /// <summary>
        /// 用于创建 Cos 临时密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosCredentialRequest"/></param>
        /// <returns><see cref="CreateCosCredentialResponse"/></returns>
        public CreateCosCredentialResponse CreateCosCredentialSync(CreateCosCredentialRequest req)
        {
            return InternalRequestAsync<CreateCosCredentialResponse>(req, "CreateCosCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession");
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安卓应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidAppRequest"/></param>
        /// <returns><see cref="DeleteAndroidAppResponse"/></returns>
        public Task<DeleteAndroidAppResponse> DeleteAndroidApp(DeleteAndroidAppRequest req)
        {
            return InternalRequestAsync<DeleteAndroidAppResponse>(req, "DeleteAndroidApp");
        }

        /// <summary>
        /// 删除安卓应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidAppRequest"/></param>
        /// <returns><see cref="DeleteAndroidAppResponse"/></returns>
        public DeleteAndroidAppResponse DeleteAndroidAppSync(DeleteAndroidAppRequest req)
        {
            return InternalRequestAsync<DeleteAndroidAppResponse>(req, "DeleteAndroidApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidAppVersionRequest"/></param>
        /// <returns><see cref="DeleteAndroidAppVersionResponse"/></returns>
        public Task<DeleteAndroidAppVersionResponse> DeleteAndroidAppVersion(DeleteAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<DeleteAndroidAppVersionResponse>(req, "DeleteAndroidAppVersion");
        }

        /// <summary>
        /// 删除安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidAppVersionRequest"/></param>
        /// <returns><see cref="DeleteAndroidAppVersionResponse"/></returns>
        public DeleteAndroidAppVersionResponse DeleteAndroidAppVersionSync(DeleteAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<DeleteAndroidAppVersionResponse>(req, "DeleteAndroidAppVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安卓实例镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidInstanceImagesRequest"/></param>
        /// <returns><see cref="DeleteAndroidInstanceImagesResponse"/></returns>
        public Task<DeleteAndroidInstanceImagesResponse> DeleteAndroidInstanceImages(DeleteAndroidInstanceImagesRequest req)
        {
            return InternalRequestAsync<DeleteAndroidInstanceImagesResponse>(req, "DeleteAndroidInstanceImages");
        }

        /// <summary>
        /// 删除安卓实例镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidInstanceImagesRequest"/></param>
        /// <returns><see cref="DeleteAndroidInstanceImagesResponse"/></returns>
        public DeleteAndroidInstanceImagesResponse DeleteAndroidInstanceImagesSync(DeleteAndroidInstanceImagesRequest req)
        {
            return InternalRequestAsync<DeleteAndroidInstanceImagesResponse>(req, "DeleteAndroidInstanceImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidInstanceLabelRequest"/></param>
        /// <returns><see cref="DeleteAndroidInstanceLabelResponse"/></returns>
        public Task<DeleteAndroidInstanceLabelResponse> DeleteAndroidInstanceLabel(DeleteAndroidInstanceLabelRequest req)
        {
            return InternalRequestAsync<DeleteAndroidInstanceLabelResponse>(req, "DeleteAndroidInstanceLabel");
        }

        /// <summary>
        /// 删除安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAndroidInstanceLabelRequest"/></param>
        /// <returns><see cref="DeleteAndroidInstanceLabelResponse"/></returns>
        public DeleteAndroidInstanceLabelResponse DeleteAndroidInstanceLabelSync(DeleteAndroidInstanceLabelRequest req)
        {
            return InternalRequestAsync<DeleteAndroidInstanceLabelResponse>(req, "DeleteAndroidInstanceLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓应用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidAppsResponse"/></returns>
        public Task<DescribeAndroidAppsResponse> DescribeAndroidApps(DescribeAndroidAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidAppsResponse>(req, "DescribeAndroidApps");
        }

        /// <summary>
        /// 查询安卓应用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidAppsResponse"/></returns>
        public DescribeAndroidAppsResponse DescribeAndroidAppsSync(DescribeAndroidAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidAppsResponse>(req, "DescribeAndroidApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceAppsResponse"/></returns>
        public Task<DescribeAndroidInstanceAppsResponse> DescribeAndroidInstanceApps(DescribeAndroidInstanceAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceAppsResponse>(req, "DescribeAndroidInstanceApps");
        }

        /// <summary>
        /// 查询安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceAppsResponse"/></returns>
        public DescribeAndroidInstanceAppsResponse DescribeAndroidInstanceAppsSync(DescribeAndroidInstanceAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceAppsResponse>(req, "DescribeAndroidInstanceApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例镜像信息，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceImagesRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceImagesResponse"/></returns>
        public Task<DescribeAndroidInstanceImagesResponse> DescribeAndroidInstanceImages(DescribeAndroidInstanceImagesRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceImagesResponse>(req, "DescribeAndroidInstanceImages");
        }

        /// <summary>
        /// 查询安卓实例镜像信息，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceImagesRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceImagesResponse"/></returns>
        public DescribeAndroidInstanceImagesResponse DescribeAndroidInstanceImagesSync(DescribeAndroidInstanceImagesRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceImagesResponse>(req, "DescribeAndroidInstanceImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceLabelsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceLabelsResponse"/></returns>
        public Task<DescribeAndroidInstanceLabelsResponse> DescribeAndroidInstanceLabels(DescribeAndroidInstanceLabelsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceLabelsResponse>(req, "DescribeAndroidInstanceLabels");
        }

        /// <summary>
        /// 查询安卓实例标签
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceLabelsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceLabelsResponse"/></returns>
        public DescribeAndroidInstanceLabelsResponse DescribeAndroidInstanceLabelsSync(DescribeAndroidInstanceLabelsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceLabelsResponse>(req, "DescribeAndroidInstanceLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceTasksStatusRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceTasksStatusResponse"/></returns>
        public Task<DescribeAndroidInstanceTasksStatusResponse> DescribeAndroidInstanceTasksStatus(DescribeAndroidInstanceTasksStatusRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceTasksStatusResponse>(req, "DescribeAndroidInstanceTasksStatus");
        }

        /// <summary>
        /// 查询安卓实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstanceTasksStatusRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstanceTasksStatusResponse"/></returns>
        public DescribeAndroidInstanceTasksStatusResponse DescribeAndroidInstanceTasksStatusSync(DescribeAndroidInstanceTasksStatusRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstanceTasksStatusResponse>(req, "DescribeAndroidInstanceTasksStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesResponse"/></returns>
        public Task<DescribeAndroidInstancesResponse> DescribeAndroidInstances(DescribeAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesResponse>(req, "DescribeAndroidInstances");
        }

        /// <summary>
        /// 查询安卓实例
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesResponse"/></returns>
        public DescribeAndroidInstancesResponse DescribeAndroidInstancesSync(DescribeAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesResponse>(req, "DescribeAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安卓实例黑名单
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesAppBlacklistRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesAppBlacklistResponse"/></returns>
        public Task<DescribeAndroidInstancesAppBlacklistResponse> DescribeAndroidInstancesAppBlacklist(DescribeAndroidInstancesAppBlacklistRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesAppBlacklistResponse>(req, "DescribeAndroidInstancesAppBlacklist");
        }

        /// <summary>
        /// 查询安卓实例黑名单
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesAppBlacklistRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesAppBlacklistResponse"/></returns>
        public DescribeAndroidInstancesAppBlacklistResponse DescribeAndroidInstancesAppBlacklistSync(DescribeAndroidInstancesAppBlacklistRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesAppBlacklistResponse>(req, "DescribeAndroidInstancesAppBlacklist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安装指定应用的安卓实例
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesByAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesByAppsResponse"/></returns>
        public Task<DescribeAndroidInstancesByAppsResponse> DescribeAndroidInstancesByApps(DescribeAndroidInstancesByAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesByAppsResponse>(req, "DescribeAndroidInstancesByApps");
        }

        /// <summary>
        /// 查询安装指定应用的安卓实例
        /// </summary>
        /// <param name="req"><see cref="DescribeAndroidInstancesByAppsRequest"/></param>
        /// <returns><see cref="DescribeAndroidInstancesByAppsResponse"/></returns>
        public DescribeAndroidInstancesByAppsResponse DescribeAndroidInstancesByAppsSync(DescribeAndroidInstancesByAppsRequest req)
        {
            return InternalRequestAsync<DescribeAndroidInstancesByAppsResponse>(req, "DescribeAndroidInstancesByApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取并发总数和运行数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesCountRequest"/></param>
        /// <returns><see cref="DescribeInstancesCountResponse"/></returns>
        public Task<DescribeInstancesCountResponse> DescribeInstancesCount(DescribeInstancesCountRequest req)
        {
            return InternalRequestAsync<DescribeInstancesCountResponse>(req, "DescribeInstancesCount");
        }

        /// <summary>
        /// 获取并发总数和运行数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesCountRequest"/></param>
        /// <returns><see cref="DescribeInstancesCountResponse"/></returns>
        public DescribeInstancesCountResponse DescribeInstancesCountSync(DescribeInstancesCountRequest req)
        {
            return InternalRequestAsync<DescribeInstancesCountResponse>(req, "DescribeInstancesCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁安卓实例
        /// </summary>
        /// <param name="req"><see cref="DestroyAndroidInstancesRequest"/></param>
        /// <returns><see cref="DestroyAndroidInstancesResponse"/></returns>
        public Task<DestroyAndroidInstancesResponse> DestroyAndroidInstances(DestroyAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DestroyAndroidInstancesResponse>(req, "DestroyAndroidInstances");
        }

        /// <summary>
        /// 销毁安卓实例
        /// </summary>
        /// <param name="req"><see cref="DestroyAndroidInstancesRequest"/></param>
        /// <returns><see cref="DestroyAndroidInstancesResponse"/></returns>
        public DestroyAndroidInstancesResponse DestroyAndroidInstancesSync(DestroyAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DestroyAndroidInstancesResponse>(req, "DestroyAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量禁用安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="DisableAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="DisableAndroidInstancesAppResponse"/></returns>
        public Task<DisableAndroidInstancesAppResponse> DisableAndroidInstancesApp(DisableAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<DisableAndroidInstancesAppResponse>(req, "DisableAndroidInstancesApp");
        }

        /// <summary>
        /// 批量禁用安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="DisableAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="DisableAndroidInstancesAppResponse"/></returns>
        public DisableAndroidInstancesAppResponse DisableAndroidInstancesAppSync(DisableAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<DisableAndroidInstancesAppResponse>(req, "DisableAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将一个文件批量分发到多个实例，一次接口调用触发一次文件分发，一次文件分发只会从公网下载一次，然后文件会走内网分发到实例列表中的实例。
        /// </summary>
        /// <param name="req"><see cref="DistributeFileToAndroidInstancesRequest"/></param>
        /// <returns><see cref="DistributeFileToAndroidInstancesResponse"/></returns>
        public Task<DistributeFileToAndroidInstancesResponse> DistributeFileToAndroidInstances(DistributeFileToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DistributeFileToAndroidInstancesResponse>(req, "DistributeFileToAndroidInstances");
        }

        /// <summary>
        /// 将一个文件批量分发到多个实例，一次接口调用触发一次文件分发，一次文件分发只会从公网下载一次，然后文件会走内网分发到实例列表中的实例。
        /// </summary>
        /// <param name="req"><see cref="DistributeFileToAndroidInstancesRequest"/></param>
        /// <returns><see cref="DistributeFileToAndroidInstancesResponse"/></returns>
        public DistributeFileToAndroidInstancesResponse DistributeFileToAndroidInstancesSync(DistributeFileToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DistributeFileToAndroidInstancesResponse>(req, "DistributeFileToAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将一张照片批量分发到多个实例的相册中，一次接口调用触发一次照片分发，一次照片分发只会从公网下载一次，然后照片会走内网分发到实例列表中的实例。
        /// </summary>
        /// <param name="req"><see cref="DistributePhotoToAndroidInstancesRequest"/></param>
        /// <returns><see cref="DistributePhotoToAndroidInstancesResponse"/></returns>
        public Task<DistributePhotoToAndroidInstancesResponse> DistributePhotoToAndroidInstances(DistributePhotoToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DistributePhotoToAndroidInstancesResponse>(req, "DistributePhotoToAndroidInstances");
        }

        /// <summary>
        /// 将一张照片批量分发到多个实例的相册中，一次接口调用触发一次照片分发，一次照片分发只会从公网下载一次，然后照片会走内网分发到实例列表中的实例。
        /// </summary>
        /// <param name="req"><see cref="DistributePhotoToAndroidInstancesRequest"/></param>
        /// <returns><see cref="DistributePhotoToAndroidInstancesResponse"/></returns>
        public DistributePhotoToAndroidInstancesResponse DistributePhotoToAndroidInstancesSync(DistributePhotoToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<DistributePhotoToAndroidInstancesResponse>(req, "DistributePhotoToAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启用安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="EnableAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="EnableAndroidInstancesAppResponse"/></returns>
        public Task<EnableAndroidInstancesAppResponse> EnableAndroidInstancesApp(EnableAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<EnableAndroidInstancesAppResponse>(req, "EnableAndroidInstancesApp");
        }

        /// <summary>
        /// 批量启用安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="EnableAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="EnableAndroidInstancesAppResponse"/></returns>
        public EnableAndroidInstancesAppResponse EnableAndroidInstancesAppSync(EnableAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<EnableAndroidInstancesAppResponse>(req, "EnableAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在安卓实例上异步执行命令，命令输出结果如果内容过长会被截断
        /// </summary>
        /// <param name="req"><see cref="ExecuteCommandOnAndroidInstancesRequest"/></param>
        /// <returns><see cref="ExecuteCommandOnAndroidInstancesResponse"/></returns>
        public Task<ExecuteCommandOnAndroidInstancesResponse> ExecuteCommandOnAndroidInstances(ExecuteCommandOnAndroidInstancesRequest req)
        {
            return InternalRequestAsync<ExecuteCommandOnAndroidInstancesResponse>(req, "ExecuteCommandOnAndroidInstances");
        }

        /// <summary>
        /// 在安卓实例上异步执行命令，命令输出结果如果内容过长会被截断
        /// </summary>
        /// <param name="req"><see cref="ExecuteCommandOnAndroidInstancesRequest"/></param>
        /// <returns><see cref="ExecuteCommandOnAndroidInstancesResponse"/></returns>
        public ExecuteCommandOnAndroidInstancesResponse ExecuteCommandOnAndroidInstancesSync(ExecuteCommandOnAndroidInstancesRequest req)
        {
            return InternalRequestAsync<ExecuteCommandOnAndroidInstancesResponse>(req, "ExecuteCommandOnAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量将实例的 logcat 日志文件上传到您已授权的 COS bucket 中，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="FetchAndroidInstancesLogsRequest"/></param>
        /// <returns><see cref="FetchAndroidInstancesLogsResponse"/></returns>
        public Task<FetchAndroidInstancesLogsResponse> FetchAndroidInstancesLogs(FetchAndroidInstancesLogsRequest req)
        {
            return InternalRequestAsync<FetchAndroidInstancesLogsResponse>(req, "FetchAndroidInstancesLogs");
        }

        /// <summary>
        /// 批量将实例的 logcat 日志文件上传到您已授权的 COS bucket 中，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="FetchAndroidInstancesLogsRequest"/></param>
        /// <returns><see cref="FetchAndroidInstancesLogsResponse"/></returns>
        public FetchAndroidInstancesLogsResponse FetchAndroidInstancesLogsSync(FetchAndroidInstancesLogsRequest req)
        {
            return InternalRequestAsync<FetchAndroidInstancesLogsResponse>(req, "FetchAndroidInstancesLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入安卓实例镜像，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像导入完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="ImportAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="ImportAndroidInstanceImageResponse"/></returns>
        public Task<ImportAndroidInstanceImageResponse> ImportAndroidInstanceImage(ImportAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<ImportAndroidInstanceImageResponse>(req, "ImportAndroidInstanceImage");
        }

        /// <summary>
        /// 导入安卓实例镜像，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像导入完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="ImportAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="ImportAndroidInstanceImageResponse"/></returns>
        public ImportAndroidInstanceImageResponse ImportAndroidInstanceImageSync(ImportAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<ImportAndroidInstanceImageResponse>(req, "ImportAndroidInstanceImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安装安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="InstallAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="InstallAndroidInstancesAppResponse"/></returns>
        public Task<InstallAndroidInstancesAppResponse> InstallAndroidInstancesApp(InstallAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<InstallAndroidInstancesAppResponse>(req, "InstallAndroidInstancesApp");
        }

        /// <summary>
        /// 安装安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="InstallAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="InstallAndroidInstancesAppResponse"/></returns>
        public InstallAndroidInstancesAppResponse InstallAndroidInstancesAppSync(InstallAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<InstallAndroidInstancesAppResponse>(req, "InstallAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过 URL 安装安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="InstallAndroidInstancesAppWithURLRequest"/></param>
        /// <returns><see cref="InstallAndroidInstancesAppWithURLResponse"/></returns>
        public Task<InstallAndroidInstancesAppWithURLResponse> InstallAndroidInstancesAppWithURL(InstallAndroidInstancesAppWithURLRequest req)
        {
            return InternalRequestAsync<InstallAndroidInstancesAppWithURLResponse>(req, "InstallAndroidInstancesAppWithURL");
        }

        /// <summary>
        /// 通过 URL 安装安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="InstallAndroidInstancesAppWithURLRequest"/></param>
        /// <returns><see cref="InstallAndroidInstancesAppWithURLResponse"/></returns>
        public InstallAndroidInstancesAppWithURLResponse InstallAndroidInstancesAppWithURLSync(InstallAndroidInstancesAppWithURLRequest req)
        {
            return InternalRequestAsync<InstallAndroidInstancesAppWithURLResponse>(req, "InstallAndroidInstancesAppWithURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidAppRequest"/></param>
        /// <returns><see cref="ModifyAndroidAppResponse"/></returns>
        public Task<ModifyAndroidAppResponse> ModifyAndroidApp(ModifyAndroidAppRequest req)
        {
            return InternalRequestAsync<ModifyAndroidAppResponse>(req, "ModifyAndroidApp");
        }

        /// <summary>
        /// 修改安卓应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidAppRequest"/></param>
        /// <returns><see cref="ModifyAndroidAppResponse"/></returns>
        public ModifyAndroidAppResponse ModifyAndroidAppSync(ModifyAndroidAppRequest req)
        {
            return InternalRequestAsync<ModifyAndroidAppResponse>(req, "ModifyAndroidApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidAppVersionRequest"/></param>
        /// <returns><see cref="ModifyAndroidAppVersionResponse"/></returns>
        public Task<ModifyAndroidAppVersionResponse> ModifyAndroidAppVersion(ModifyAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidAppVersionResponse>(req, "ModifyAndroidAppVersion");
        }

        /// <summary>
        /// 修改安卓应用版本
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidAppVersionRequest"/></param>
        /// <returns><see cref="ModifyAndroidAppVersionResponse"/></returns>
        public ModifyAndroidAppVersionResponse ModifyAndroidAppVersionSync(ModifyAndroidAppVersionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidAppVersionResponse>(req, "ModifyAndroidAppVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓实例的信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstanceInformationRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstanceInformationResponse"/></returns>
        public Task<ModifyAndroidInstanceInformationResponse> ModifyAndroidInstanceInformation(ModifyAndroidInstanceInformationRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstanceInformationResponse>(req, "ModifyAndroidInstanceInformation");
        }

        /// <summary>
        /// 修改安卓实例的信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstanceInformationRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstanceInformationResponse"/></returns>
        public ModifyAndroidInstanceInformationResponse ModifyAndroidInstanceInformationSync(ModifyAndroidInstanceInformationRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstanceInformationResponse>(req, "ModifyAndroidInstanceInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓实例分辨率。需要注意的是该接口可能导致正在运行的应用出现闪退，所以建议在实例维护时期才进行调用。
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstanceResolutionRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstanceResolutionResponse"/></returns>
        public Task<ModifyAndroidInstanceResolutionResponse> ModifyAndroidInstanceResolution(ModifyAndroidInstanceResolutionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstanceResolutionResponse>(req, "ModifyAndroidInstanceResolution");
        }

        /// <summary>
        /// 修改安卓实例分辨率。需要注意的是该接口可能导致正在运行的应用出现闪退，所以建议在实例维护时期才进行调用。
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstanceResolutionRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstanceResolutionResponse"/></returns>
        public ModifyAndroidInstanceResolutionResponse ModifyAndroidInstanceResolutionSync(ModifyAndroidInstanceResolutionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstanceResolutionResponse>(req, "ModifyAndroidInstanceResolution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓实例应用黑名单
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesAppBlacklistRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesAppBlacklistResponse"/></returns>
        public Task<ModifyAndroidInstancesAppBlacklistResponse> ModifyAndroidInstancesAppBlacklist(ModifyAndroidInstancesAppBlacklistRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesAppBlacklistResponse>(req, "ModifyAndroidInstancesAppBlacklist");
        }

        /// <summary>
        /// 修改安卓实例应用黑名单
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesAppBlacklistRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesAppBlacklistResponse"/></returns>
        public ModifyAndroidInstancesAppBlacklistResponse ModifyAndroidInstancesAppBlacklistSync(ModifyAndroidInstancesAppBlacklistRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesAppBlacklistResponse>(req, "ModifyAndroidInstancesAppBlacklist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改安卓实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesInformationRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesInformationResponse"/></returns>
        public Task<ModifyAndroidInstancesInformationResponse> ModifyAndroidInstancesInformation(ModifyAndroidInstancesInformationRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesInformationResponse>(req, "ModifyAndroidInstancesInformation");
        }

        /// <summary>
        /// 批量修改安卓实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesInformationRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesInformationResponse"/></returns>
        public ModifyAndroidInstancesInformationResponse ModifyAndroidInstancesInformationSync(ModifyAndroidInstancesInformationRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesInformationResponse>(req, "ModifyAndroidInstancesInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改安卓实例的标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesLabelsRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesLabelsResponse"/></returns>
        public Task<ModifyAndroidInstancesLabelsResponse> ModifyAndroidInstancesLabels(ModifyAndroidInstancesLabelsRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesLabelsResponse>(req, "ModifyAndroidInstancesLabels");
        }

        /// <summary>
        /// 批量修改安卓实例的标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesLabelsRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesLabelsResponse"/></returns>
        public ModifyAndroidInstancesLabelsResponse ModifyAndroidInstancesLabelsSync(ModifyAndroidInstancesLabelsRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesLabelsResponse>(req, "ModifyAndroidInstancesLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改安卓实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesPropertiesRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesPropertiesResponse"/></returns>
        public Task<ModifyAndroidInstancesPropertiesResponse> ModifyAndroidInstancesProperties(ModifyAndroidInstancesPropertiesRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesPropertiesResponse>(req, "ModifyAndroidInstancesProperties");
        }

        /// <summary>
        /// 批量修改安卓实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesPropertiesRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesPropertiesResponse"/></returns>
        public ModifyAndroidInstancesPropertiesResponse ModifyAndroidInstancesPropertiesSync(ModifyAndroidInstancesPropertiesRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesPropertiesResponse>(req, "ModifyAndroidInstancesProperties")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安卓实例分辨率。需要注意的是该接口需要重启才能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesResolutionRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesResolutionResponse"/></returns>
        public Task<ModifyAndroidInstancesResolutionResponse> ModifyAndroidInstancesResolution(ModifyAndroidInstancesResolutionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesResolutionResponse>(req, "ModifyAndroidInstancesResolution");
        }

        /// <summary>
        /// 修改安卓实例分辨率。需要注意的是该接口需要重启才能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesResolutionRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesResolutionResponse"/></returns>
        public ModifyAndroidInstancesResolutionResponse ModifyAndroidInstancesResolutionSync(ModifyAndroidInstancesResolutionRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesResolutionResponse>(req, "ModifyAndroidInstancesResolution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改安卓实例资源限制
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesResourcesRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesResourcesResponse"/></returns>
        public Task<ModifyAndroidInstancesResourcesResponse> ModifyAndroidInstancesResources(ModifyAndroidInstancesResourcesRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesResourcesResponse>(req, "ModifyAndroidInstancesResources");
        }

        /// <summary>
        /// 批量修改安卓实例资源限制
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesResourcesRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesResourcesResponse"/></returns>
        public ModifyAndroidInstancesResourcesResponse ModifyAndroidInstancesResourcesSync(ModifyAndroidInstancesResourcesRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesResourcesResponse>(req, "ModifyAndroidInstancesResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改安卓实例的用户ID
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesUserIdRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesUserIdResponse"/></returns>
        public Task<ModifyAndroidInstancesUserIdResponse> ModifyAndroidInstancesUserId(ModifyAndroidInstancesUserIdRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesUserIdResponse>(req, "ModifyAndroidInstancesUserId");
        }

        /// <summary>
        /// 批量修改安卓实例的用户ID
        /// </summary>
        /// <param name="req"><see cref="ModifyAndroidInstancesUserIdRequest"/></param>
        /// <returns><see cref="ModifyAndroidInstancesUserIdResponse"/></returns>
        public ModifyAndroidInstancesUserIdResponse ModifyAndroidInstancesUserIdSync(ModifyAndroidInstancesUserIdRequest req)
        {
            return InternalRequestAsync<ModifyAndroidInstancesUserIdResponse>(req, "ModifyAndroidInstancesUserId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启安卓实例宿主机。请注意：
        /// 
        /// - 当前每 15 分钟只能重启一次
        /// - 一个宿主机可能有多个云手机实例，重启宿主机会影响运行在上面的所有实例，请确保该宿主机上的所有云手机实例未投入业务使用
        /// </summary>
        /// <param name="req"><see cref="RebootAndroidInstanceHostsRequest"/></param>
        /// <returns><see cref="RebootAndroidInstanceHostsResponse"/></returns>
        public Task<RebootAndroidInstanceHostsResponse> RebootAndroidInstanceHosts(RebootAndroidInstanceHostsRequest req)
        {
            return InternalRequestAsync<RebootAndroidInstanceHostsResponse>(req, "RebootAndroidInstanceHosts");
        }

        /// <summary>
        /// 重启安卓实例宿主机。请注意：
        /// 
        /// - 当前每 15 分钟只能重启一次
        /// - 一个宿主机可能有多个云手机实例，重启宿主机会影响运行在上面的所有实例，请确保该宿主机上的所有云手机实例未投入业务使用
        /// </summary>
        /// <param name="req"><see cref="RebootAndroidInstanceHostsRequest"/></param>
        /// <returns><see cref="RebootAndroidInstanceHostsResponse"/></returns>
        public RebootAndroidInstanceHostsResponse RebootAndroidInstanceHostsSync(RebootAndroidInstanceHostsRequest req)
        {
            return InternalRequestAsync<RebootAndroidInstanceHostsResponse>(req, "RebootAndroidInstanceHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启安卓实例
        /// </summary>
        /// <param name="req"><see cref="RebootAndroidInstancesRequest"/></param>
        /// <returns><see cref="RebootAndroidInstancesResponse"/></returns>
        public Task<RebootAndroidInstancesResponse> RebootAndroidInstances(RebootAndroidInstancesRequest req)
        {
            return InternalRequestAsync<RebootAndroidInstancesResponse>(req, "RebootAndroidInstances");
        }

        /// <summary>
        /// 重启安卓实例
        /// </summary>
        /// <param name="req"><see cref="RebootAndroidInstancesRequest"/></param>
        /// <returns><see cref="RebootAndroidInstancesResponse"/></returns>
        public RebootAndroidInstancesResponse RebootAndroidInstancesSync(RebootAndroidInstancesRequest req)
        {
            return InternalRequestAsync<RebootAndroidInstancesResponse>(req, "RebootAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置安卓实例
        /// </summary>
        /// <param name="req"><see cref="ResetAndroidInstancesRequest"/></param>
        /// <returns><see cref="ResetAndroidInstancesResponse"/></returns>
        public Task<ResetAndroidInstancesResponse> ResetAndroidInstances(ResetAndroidInstancesRequest req)
        {
            return InternalRequestAsync<ResetAndroidInstancesResponse>(req, "ResetAndroidInstances");
        }

        /// <summary>
        /// 重置安卓实例
        /// </summary>
        /// <param name="req"><see cref="ResetAndroidInstancesRequest"/></param>
        /// <returns><see cref="ResetAndroidInstancesResponse"/></returns>
        public ResetAndroidInstancesResponse ResetAndroidInstancesSync(ResetAndroidInstancesRequest req)
        {
            return InternalRequestAsync<ResetAndroidInstancesResponse>(req, "ResetAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="RestartAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="RestartAndroidInstancesAppResponse"/></returns>
        public Task<RestartAndroidInstancesAppResponse> RestartAndroidInstancesApp(RestartAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<RestartAndroidInstancesAppResponse>(req, "RestartAndroidInstancesApp");
        }

        /// <summary>
        /// 重启安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="RestartAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="RestartAndroidInstancesAppResponse"/></returns>
        public RestartAndroidInstancesAppResponse RestartAndroidInstancesAppSync(RestartAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<RestartAndroidInstancesAppResponse>(req, "RestartAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用指定存储数据还原云手机，支持 COS 和兼容 AWS S3 协议的对象存储服务。如果还原数据来自 COS 时，会使用公网流量，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="RestoreAndroidInstanceFromStorageRequest"/></param>
        /// <returns><see cref="RestoreAndroidInstanceFromStorageResponse"/></returns>
        public Task<RestoreAndroidInstanceFromStorageResponse> RestoreAndroidInstanceFromStorage(RestoreAndroidInstanceFromStorageRequest req)
        {
            return InternalRequestAsync<RestoreAndroidInstanceFromStorageResponse>(req, "RestoreAndroidInstanceFromStorage");
        }

        /// <summary>
        /// 使用指定存储数据还原云手机，支持 COS 和兼容 AWS S3 协议的对象存储服务。如果还原数据来自 COS 时，会使用公网流量，授权 COS bucket 请在控制台中操作。
        /// </summary>
        /// <param name="req"><see cref="RestoreAndroidInstanceFromStorageRequest"/></param>
        /// <returns><see cref="RestoreAndroidInstanceFromStorageResponse"/></returns>
        public RestoreAndroidInstanceFromStorageResponse RestoreAndroidInstanceFromStorageSync(RestoreAndroidInstanceFromStorageRequest req)
        {
            return InternalRequestAsync<RestoreAndroidInstanceFromStorageResponse>(req, "RestoreAndroidInstanceFromStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存游戏存档
        /// </summary>
        /// <param name="req"><see cref="SaveGameArchiveRequest"/></param>
        /// <returns><see cref="SaveGameArchiveResponse"/></returns>
        public Task<SaveGameArchiveResponse> SaveGameArchive(SaveGameArchiveRequest req)
        {
            return InternalRequestAsync<SaveGameArchiveResponse>(req, "SaveGameArchive");
        }

        /// <summary>
        /// 保存游戏存档
        /// </summary>
        /// <param name="req"><see cref="SaveGameArchiveRequest"/></param>
        /// <returns><see cref="SaveGameArchiveResponse"/></returns>
        public SaveGameArchiveResponse SaveGameArchiveSync(SaveGameArchiveRequest req)
        {
            return InternalRequestAsync<SaveGameArchiveResponse>(req, "SaveGameArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量设置安卓实例应用后台保活，开启应用保活，只是降低应用被杀死或回收的优先级，并不能保证应用不会被杀死或回收（如出现内存不足等资源限制时，应用也有概率被杀死或回收）
        /// </summary>
        /// <param name="req"><see cref="SetAndroidInstancesBGAppKeepAliveRequest"/></param>
        /// <returns><see cref="SetAndroidInstancesBGAppKeepAliveResponse"/></returns>
        public Task<SetAndroidInstancesBGAppKeepAliveResponse> SetAndroidInstancesBGAppKeepAlive(SetAndroidInstancesBGAppKeepAliveRequest req)
        {
            return InternalRequestAsync<SetAndroidInstancesBGAppKeepAliveResponse>(req, "SetAndroidInstancesBGAppKeepAlive");
        }

        /// <summary>
        /// 批量设置安卓实例应用后台保活，开启应用保活，只是降低应用被杀死或回收的优先级，并不能保证应用不会被杀死或回收（如出现内存不足等资源限制时，应用也有概率被杀死或回收）
        /// </summary>
        /// <param name="req"><see cref="SetAndroidInstancesBGAppKeepAliveRequest"/></param>
        /// <returns><see cref="SetAndroidInstancesBGAppKeepAliveResponse"/></returns>
        public SetAndroidInstancesBGAppKeepAliveResponse SetAndroidInstancesBGAppKeepAliveSync(SetAndroidInstancesBGAppKeepAliveRequest req)
        {
            return InternalRequestAsync<SetAndroidInstancesBGAppKeepAliveResponse>(req, "SetAndroidInstancesBGAppKeepAlive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量设置安卓实例应用前台保活，开启应用保活，只是降低应用被杀死或回收的优先级，并不能保证应用不会被杀死或回收（如出现内存不足等资源限制时，应用也有概率被杀死或回收）
        /// </summary>
        /// <param name="req"><see cref="SetAndroidInstancesFGAppKeepAliveRequest"/></param>
        /// <returns><see cref="SetAndroidInstancesFGAppKeepAliveResponse"/></returns>
        public Task<SetAndroidInstancesFGAppKeepAliveResponse> SetAndroidInstancesFGAppKeepAlive(SetAndroidInstancesFGAppKeepAliveRequest req)
        {
            return InternalRequestAsync<SetAndroidInstancesFGAppKeepAliveResponse>(req, "SetAndroidInstancesFGAppKeepAlive");
        }

        /// <summary>
        /// 批量设置安卓实例应用前台保活，开启应用保活，只是降低应用被杀死或回收的优先级，并不能保证应用不会被杀死或回收（如出现内存不足等资源限制时，应用也有概率被杀死或回收）
        /// </summary>
        /// <param name="req"><see cref="SetAndroidInstancesFGAppKeepAliveRequest"/></param>
        /// <returns><see cref="SetAndroidInstancesFGAppKeepAliveResponse"/></returns>
        public SetAndroidInstancesFGAppKeepAliveResponse SetAndroidInstancesFGAppKeepAliveSync(SetAndroidInstancesFGAppKeepAliveRequest req)
        {
            return InternalRequestAsync<SetAndroidInstancesFGAppKeepAliveResponse>(req, "SetAndroidInstancesFGAppKeepAlive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开机安卓实例
        /// </summary>
        /// <param name="req"><see cref="StartAndroidInstancesRequest"/></param>
        /// <returns><see cref="StartAndroidInstancesResponse"/></returns>
        public Task<StartAndroidInstancesResponse> StartAndroidInstances(StartAndroidInstancesRequest req)
        {
            return InternalRequestAsync<StartAndroidInstancesResponse>(req, "StartAndroidInstances");
        }

        /// <summary>
        /// 开机安卓实例
        /// </summary>
        /// <param name="req"><see cref="StartAndroidInstancesRequest"/></param>
        /// <returns><see cref="StartAndroidInstancesResponse"/></returns>
        public StartAndroidInstancesResponse StartAndroidInstancesSync(StartAndroidInstancesRequest req)
        {
            return InternalRequestAsync<StartAndroidInstancesResponse>(req, "StartAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="StartAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="StartAndroidInstancesAppResponse"/></returns>
        public Task<StartAndroidInstancesAppResponse> StartAndroidInstancesApp(StartAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<StartAndroidInstancesAppResponse>(req, "StartAndroidInstancesApp");
        }

        /// <summary>
        /// 启动安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="StartAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="StartAndroidInstancesAppResponse"/></returns>
        public StartAndroidInstancesAppResponse StartAndroidInstancesAppSync(StartAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<StartAndroidInstancesAppResponse>(req, "StartAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public Task<StartPublishStreamResponse> StartPublishStream(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream");
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public StartPublishStreamResponse StartPublishStreamSync(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamToCSSRequest"/></param>
        /// <returns><see cref="StartPublishStreamToCSSResponse"/></returns>
        public Task<StartPublishStreamToCSSResponse> StartPublishStreamToCSS(StartPublishStreamToCSSRequest req)
        {
            return InternalRequestAsync<StartPublishStreamToCSSResponse>(req, "StartPublishStreamToCSS");
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamToCSSRequest"/></param>
        /// <returns><see cref="StartPublishStreamToCSSResponse"/></returns>
        public StartPublishStreamToCSSResponse StartPublishStreamToCSSSync(StartPublishStreamToCSSRequest req)
        {
            return InternalRequestAsync<StartPublishStreamToCSSResponse>(req, "StartPublishStreamToCSS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关机安卓实例
        /// </summary>
        /// <param name="req"><see cref="StopAndroidInstancesRequest"/></param>
        /// <returns><see cref="StopAndroidInstancesResponse"/></returns>
        public Task<StopAndroidInstancesResponse> StopAndroidInstances(StopAndroidInstancesRequest req)
        {
            return InternalRequestAsync<StopAndroidInstancesResponse>(req, "StopAndroidInstances");
        }

        /// <summary>
        /// 关机安卓实例
        /// </summary>
        /// <param name="req"><see cref="StopAndroidInstancesRequest"/></param>
        /// <returns><see cref="StopAndroidInstancesResponse"/></returns>
        public StopAndroidInstancesResponse StopAndroidInstancesSync(StopAndroidInstancesRequest req)
        {
            return InternalRequestAsync<StopAndroidInstancesResponse>(req, "StopAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="StopAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="StopAndroidInstancesAppResponse"/></returns>
        public Task<StopAndroidInstancesAppResponse> StopAndroidInstancesApp(StopAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<StopAndroidInstancesAppResponse>(req, "StopAndroidInstancesApp");
        }

        /// <summary>
        /// 停止安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="StopAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="StopAndroidInstancesAppResponse"/></returns>
        public StopAndroidInstancesAppResponse StopAndroidInstancesAppSync(StopAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<StopAndroidInstancesAppResponse>(req, "StopAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public Task<StopGameResponse> StopGame(StopGameRequest req)
        {
            return InternalRequestAsync<StopGameResponse>(req, "StopGame");
        }

        /// <summary>
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public StopGameResponse StopGameSync(StopGameRequest req)
        {
            return InternalRequestAsync<StopGameResponse>(req, "StopGame")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public Task<StopPublishStreamResponse> StopPublishStream(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream");
        }

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public StopPublishStreamResponse StopPublishStreamSync(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换游戏存档
        /// </summary>
        /// <param name="req"><see cref="SwitchGameArchiveRequest"/></param>
        /// <returns><see cref="SwitchGameArchiveResponse"/></returns>
        public Task<SwitchGameArchiveResponse> SwitchGameArchive(SwitchGameArchiveRequest req)
        {
            return InternalRequestAsync<SwitchGameArchiveResponse>(req, "SwitchGameArchive");
        }

        /// <summary>
        /// 切换游戏存档
        /// </summary>
        /// <param name="req"><see cref="SwitchGameArchiveRequest"/></param>
        /// <returns><see cref="SwitchGameArchiveResponse"/></returns>
        public SwitchGameArchiveResponse SwitchGameArchiveSync(SwitchGameArchiveRequest req)
        {
            return InternalRequestAsync<SwitchGameArchiveResponse>(req, "SwitchGameArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步安卓实例镜像到其他区域，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像已经同步完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="SyncAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="SyncAndroidInstanceImageResponse"/></returns>
        public Task<SyncAndroidInstanceImageResponse> SyncAndroidInstanceImage(SyncAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<SyncAndroidInstanceImageResponse>(req, "SyncAndroidInstanceImage");
        }

        /// <summary>
        /// 同步安卓实例镜像到其他区域，当镜像的 AndroidInstanceImageState 为 NORMAL 时，镜像已经同步完成处于可用状态。
        /// </summary>
        /// <param name="req"><see cref="SyncAndroidInstanceImageRequest"/></param>
        /// <returns><see cref="SyncAndroidInstanceImageResponse"/></returns>
        public SyncAndroidInstanceImageResponse SyncAndroidInstanceImageSync(SyncAndroidInstanceImageRequest req)
        {
            return InternalRequestAsync<SyncAndroidInstanceImageResponse>(req, "SyncAndroidInstanceImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在安卓实例上同步执行命令，仅支持1秒内可以返回结果的命令，例如：ls、cd。同时执行的实例数量不能过多，否则可能云api返回超时。不支持超过1秒无法返回或无法自主结束的命令，例如：top、vim，执行结果最大1KB
        /// </summary>
        /// <param name="req"><see cref="SyncExecuteCommandOnAndroidInstancesRequest"/></param>
        /// <returns><see cref="SyncExecuteCommandOnAndroidInstancesResponse"/></returns>
        public Task<SyncExecuteCommandOnAndroidInstancesResponse> SyncExecuteCommandOnAndroidInstances(SyncExecuteCommandOnAndroidInstancesRequest req)
        {
            return InternalRequestAsync<SyncExecuteCommandOnAndroidInstancesResponse>(req, "SyncExecuteCommandOnAndroidInstances");
        }

        /// <summary>
        /// 在安卓实例上同步执行命令，仅支持1秒内可以返回结果的命令，例如：ls、cd。同时执行的实例数量不能过多，否则可能云api返回超时。不支持超过1秒无法返回或无法自主结束的命令，例如：top、vim，执行结果最大1KB
        /// </summary>
        /// <param name="req"><see cref="SyncExecuteCommandOnAndroidInstancesRequest"/></param>
        /// <returns><see cref="SyncExecuteCommandOnAndroidInstancesResponse"/></returns>
        public SyncExecuteCommandOnAndroidInstancesResponse SyncExecuteCommandOnAndroidInstancesSync(SyncExecuteCommandOnAndroidInstancesRequest req)
        {
            return InternalRequestAsync<SyncExecuteCommandOnAndroidInstancesResponse>(req, "SyncExecuteCommandOnAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public Task<TrylockWorkerResponse> TrylockWorker(TrylockWorkerRequest req)
        {
            return InternalRequestAsync<TrylockWorkerResponse>(req, "TrylockWorker");
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public TrylockWorkerResponse TrylockWorkerSync(TrylockWorkerRequest req)
        {
            return InternalRequestAsync<TrylockWorkerResponse>(req, "TrylockWorker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 卸载安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="UninstallAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="UninstallAndroidInstancesAppResponse"/></returns>
        public Task<UninstallAndroidInstancesAppResponse> UninstallAndroidInstancesApp(UninstallAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<UninstallAndroidInstancesAppResponse>(req, "UninstallAndroidInstancesApp");
        }

        /// <summary>
        /// 卸载安卓实例应用
        /// </summary>
        /// <param name="req"><see cref="UninstallAndroidInstancesAppRequest"/></param>
        /// <returns><see cref="UninstallAndroidInstancesAppResponse"/></returns>
        public UninstallAndroidInstancesAppResponse UninstallAndroidInstancesAppSync(UninstallAndroidInstancesAppRequest req)
        {
            return InternalRequestAsync<UninstallAndroidInstancesAppResponse>(req, "UninstallAndroidInstancesApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将文件下载到指定实例列表的实例上，每个实例都会从公网下载文件。如果您需要将同一个文件分发到多个实例，建议使用 DistributeFileToAndroidInstances 接口减少公网下载的流量。如果您需要将不同的文件下载到不同的实例，可考虑使用 UploadFilesToAndroidInstances 接口批量将不同文件下载到不同的实例。
        /// </summary>
        /// <param name="req"><see cref="UploadFileToAndroidInstancesRequest"/></param>
        /// <returns><see cref="UploadFileToAndroidInstancesResponse"/></returns>
        public Task<UploadFileToAndroidInstancesResponse> UploadFileToAndroidInstances(UploadFileToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<UploadFileToAndroidInstancesResponse>(req, "UploadFileToAndroidInstances");
        }

        /// <summary>
        /// 将文件下载到指定实例列表的实例上，每个实例都会从公网下载文件。如果您需要将同一个文件分发到多个实例，建议使用 DistributeFileToAndroidInstances 接口减少公网下载的流量。如果您需要将不同的文件下载到不同的实例，可考虑使用 UploadFilesToAndroidInstances 接口批量将不同文件下载到不同的实例。
        /// </summary>
        /// <param name="req"><see cref="UploadFileToAndroidInstancesRequest"/></param>
        /// <returns><see cref="UploadFileToAndroidInstancesResponse"/></returns>
        public UploadFileToAndroidInstancesResponse UploadFileToAndroidInstancesSync(UploadFileToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<UploadFileToAndroidInstancesResponse>(req, "UploadFileToAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量将不同的文件下载到不同的实例，每个实例下载文件都是从公网下载，建议只用在文件下载使用一次的场景。如果您需要将同一个文件分发到不同实例，建议使用 DistributeFileToAndroidInstances 接口。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesToAndroidInstancesRequest"/></param>
        /// <returns><see cref="UploadFilesToAndroidInstancesResponse"/></returns>
        public Task<UploadFilesToAndroidInstancesResponse> UploadFilesToAndroidInstances(UploadFilesToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<UploadFilesToAndroidInstancesResponse>(req, "UploadFilesToAndroidInstances");
        }

        /// <summary>
        /// 批量将不同的文件下载到不同的实例，每个实例下载文件都是从公网下载，建议只用在文件下载使用一次的场景。如果您需要将同一个文件分发到不同实例，建议使用 DistributeFileToAndroidInstances 接口。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesToAndroidInstancesRequest"/></param>
        /// <returns><see cref="UploadFilesToAndroidInstancesResponse"/></returns>
        public UploadFilesToAndroidInstancesResponse UploadFilesToAndroidInstancesSync(UploadFilesToAndroidInstancesRequest req)
        {
            return InternalRequestAsync<UploadFilesToAndroidInstancesResponse>(req, "UploadFilesToAndroidInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
