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

namespace TencentCloud.Drm.V20181115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Drm.V20181115.Models;

   public class DrmClient : AbstractClient{

       private const string endpoint = "drm.tencentcloudapi.com";
       private const string version = "2018-11-15";
       private const string sdkVersion = "SDK_NET_3.0.1089";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DrmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DrmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req"><see cref="AddFairPlayPemRequest"/></param>
        /// <returns><see cref="AddFairPlayPemResponse"/></returns>
        public Task<AddFairPlayPemResponse> AddFairPlayPem(AddFairPlayPemRequest req)
        {
            return InternalRequestAsync<AddFairPlayPemResponse>(req, "AddFairPlayPem");
        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req"><see cref="AddFairPlayPemRequest"/></param>
        /// <returns><see cref="AddFairPlayPemResponse"/></returns>
        public AddFairPlayPemResponse AddFairPlayPemSync(AddFairPlayPemRequest req)
        {
            return InternalRequestAsync<AddFairPlayPemResponse>(req, "AddFairPlayPem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来设置加密的密钥。注意，同一个content id，只能设置一次！
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptKeysRequest"/></param>
        /// <returns><see cref="CreateEncryptKeysResponse"/></returns>
        public Task<CreateEncryptKeysResponse> CreateEncryptKeys(CreateEncryptKeysRequest req)
        {
            return InternalRequestAsync<CreateEncryptKeysResponse>(req, "CreateEncryptKeys");
        }

        /// <summary>
        /// 该接口用来设置加密的密钥。注意，同一个content id，只能设置一次！
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptKeysRequest"/></param>
        /// <returns><see cref="CreateEncryptKeysResponse"/></returns>
        public CreateEncryptKeysResponse CreateEncryptKeysSync(CreateEncryptKeysRequest req)
        {
            return InternalRequestAsync<CreateEncryptKeysResponse>(req, "CreateEncryptKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来生成DRM方案对应的播放许可证，开发者需提供DRM方案类型、内容类型参数，后台将生成许可证后返回许可证数据
        /// 开发者需要转发终端设备发出的许可证请求信息。
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseRequest"/></param>
        /// <returns><see cref="CreateLicenseResponse"/></returns>
        public Task<CreateLicenseResponse> CreateLicense(CreateLicenseRequest req)
        {
            return InternalRequestAsync<CreateLicenseResponse>(req, "CreateLicense");
        }

        /// <summary>
        /// 本接口用来生成DRM方案对应的播放许可证，开发者需提供DRM方案类型、内容类型参数，后台将生成许可证后返回许可证数据
        /// 开发者需要转发终端设备发出的许可证请求信息。
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseRequest"/></param>
        /// <returns><see cref="CreateLicenseResponse"/></returns>
        public CreateLicenseResponse CreateLicenseSync(CreateLicenseRequest req)
        {
            return InternalRequestAsync<CreateLicenseResponse>(req, "CreateLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来删除fairplay方案的私钥、ask等信息
        /// 注：高风险操作，删除后，您将无法使用腾讯云DRM提供的fairplay服务。
        /// 由于缓存，删除操作需要约半小时生效
        /// </summary>
        /// <param name="req"><see cref="DeleteFairPlayPemRequest"/></param>
        /// <returns><see cref="DeleteFairPlayPemResponse"/></returns>
        public Task<DeleteFairPlayPemResponse> DeleteFairPlayPem(DeleteFairPlayPemRequest req)
        {
            return InternalRequestAsync<DeleteFairPlayPemResponse>(req, "DeleteFairPlayPem");
        }

        /// <summary>
        /// 本接口用来删除fairplay方案的私钥、ask等信息
        /// 注：高风险操作，删除后，您将无法使用腾讯云DRM提供的fairplay服务。
        /// 由于缓存，删除操作需要约半小时生效
        /// </summary>
        /// <param name="req"><see cref="DeleteFairPlayPemRequest"/></param>
        /// <returns><see cref="DeleteFairPlayPemResponse"/></returns>
        public DeleteFairPlayPemResponse DeleteFairPlayPemSync(DeleteFairPlayPemRequest req)
        {
            return InternalRequestAsync<DeleteFairPlayPemResponse>(req, "DeleteFairPlayPem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询指定DRM类型、ContentType的所有加密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeAllKeysRequest"/></param>
        /// <returns><see cref="DescribeAllKeysResponse"/></returns>
        public Task<DescribeAllKeysResponse> DescribeAllKeys(DescribeAllKeysRequest req)
        {
            return InternalRequestAsync<DescribeAllKeysResponse>(req, "DescribeAllKeys");
        }

        /// <summary>
        /// 本接口用来查询指定DRM类型、ContentType的所有加密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeAllKeysRequest"/></param>
        /// <returns><see cref="DescribeAllKeysResponse"/></returns>
        public DescribeAllKeysResponse DescribeAllKeysSync(DescribeAllKeysRequest req)
        {
            return InternalRequestAsync<DescribeAllKeysResponse>(req, "DescribeAllKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型取值 NORMALAES、和需要加密的Track类型取值 SD,ContentType取值 LiveVideo
        /// </summary>
        /// <param name="req"><see cref="DescribeDRMLicenseRequest"/></param>
        /// <returns><see cref="DescribeDRMLicenseResponse"/></returns>
        public Task<DescribeDRMLicenseResponse> DescribeDRMLicense(DescribeDRMLicenseRequest req)
        {
            return InternalRequestAsync<DescribeDRMLicenseResponse>(req, "DescribeDRMLicense");
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型取值 NORMALAES、和需要加密的Track类型取值 SD,ContentType取值 LiveVideo
        /// </summary>
        /// <param name="req"><see cref="DescribeDRMLicenseRequest"/></param>
        /// <returns><see cref="DescribeDRMLicenseResponse"/></returns>
        public DescribeDRMLicenseResponse DescribeDRMLicenseSync(DescribeDRMLicenseRequest req)
        {
            return InternalRequestAsync<DescribeDRMLicenseResponse>(req, "DescribeDRMLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来查询设置的FairPlay私钥校验信息。可用该接口校验设置的私钥与本身的私钥是否一致。
        /// </summary>
        /// <param name="req"><see cref="DescribeFairPlayPemRequest"/></param>
        /// <returns><see cref="DescribeFairPlayPemResponse"/></returns>
        public Task<DescribeFairPlayPemResponse> DescribeFairPlayPem(DescribeFairPlayPemRequest req)
        {
            return InternalRequestAsync<DescribeFairPlayPemResponse>(req, "DescribeFairPlayPem");
        }

        /// <summary>
        /// 该接口用来查询设置的FairPlay私钥校验信息。可用该接口校验设置的私钥与本身的私钥是否一致。
        /// </summary>
        /// <param name="req"><see cref="DescribeFairPlayPemRequest"/></param>
        /// <returns><see cref="DescribeFairPlayPemResponse"/></returns>
        public DescribeFairPlayPemResponse DescribeFairPlayPemSync(DescribeFairPlayPemRequest req)
        {
            return InternalRequestAsync<DescribeFairPlayPemResponse>(req, "DescribeFairPlayPem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型、和需要加密的Track类型，后台返回加密使用的密钥
        /// 如果加密使用的ContentID没有关联的密钥信息，后台会自动生成新的密钥返回
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys");
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型、和需要加密的Track类型，后台返回加密使用的密钥
        /// 如果加密使用的ContentID没有关联的密钥信息，后台会自动生成新的密钥返回
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public DescribeKeysResponse DescribeKeysSync(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型取值 NORMALAES、和需要加密的Track类型取值 SD,ContentType取值 LiveVideo
        /// </summary>
        /// <param name="req"><see cref="GenerateTDRMKeyRequest"/></param>
        /// <returns><see cref="GenerateTDRMKeyResponse"/></returns>
        public Task<GenerateTDRMKeyResponse> GenerateTDRMKey(GenerateTDRMKeyRequest req)
        {
            return InternalRequestAsync<GenerateTDRMKeyResponse>(req, "GenerateTDRMKey");
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型取值 NORMALAES、和需要加密的Track类型取值 SD,ContentType取值 LiveVideo
        /// </summary>
        /// <param name="req"><see cref="GenerateTDRMKeyRequest"/></param>
        /// <returns><see cref="GenerateTDRMKeyResponse"/></returns>
        public GenerateTDRMKeyResponse GenerateTDRMKeySync(GenerateTDRMKeyRequest req)
        {
            return InternalRequestAsync<GenerateTDRMKeyResponse>(req, "GenerateTDRMKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req"><see cref="ModifyFairPlayPemRequest"/></param>
        /// <returns><see cref="ModifyFairPlayPemResponse"/></returns>
        public Task<ModifyFairPlayPemResponse> ModifyFairPlayPem(ModifyFairPlayPemRequest req)
        {
            return InternalRequestAsync<ModifyFairPlayPemResponse>(req, "ModifyFairPlayPem");
        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req"><see cref="ModifyFairPlayPemRequest"/></param>
        /// <returns><see cref="ModifyFairPlayPemResponse"/></returns>
        public ModifyFairPlayPemResponse ModifyFairPlayPemSync(ModifyFairPlayPemRequest req)
        {
            return InternalRequestAsync<ModifyFairPlayPemResponse>(req, "ModifyFairPlayPem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发者调用该接口，启动一次内容文件的DRM加密工作流。
        /// 注意：该接口已下线。
        /// </summary>
        /// <param name="req"><see cref="StartEncryptionRequest"/></param>
        /// <returns><see cref="StartEncryptionResponse"/></returns>
        public Task<StartEncryptionResponse> StartEncryption(StartEncryptionRequest req)
        {
            return InternalRequestAsync<StartEncryptionResponse>(req, "StartEncryption");
        }

        /// <summary>
        /// 开发者调用该接口，启动一次内容文件的DRM加密工作流。
        /// 注意：该接口已下线。
        /// </summary>
        /// <param name="req"><see cref="StartEncryptionRequest"/></param>
        /// <returns><see cref="StartEncryptionResponse"/></returns>
        public StartEncryptionResponse StartEncryptionSync(StartEncryptionRequest req)
        {
            return InternalRequestAsync<StartEncryptionResponse>(req, "StartEncryption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
