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

namespace TencentCloud.Kms.V20190118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Kms.V20190118.Models;

   public class KmsClient : AbstractClient{

       private const string endpoint = "kms.tencentcloudapi.com";
       private const string version = "2019-01-18";
       private const string sdkVersion = "SDK_NET_3.0.1250";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public KmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 对密钥进行归档，被归档的密钥只能用于解密，不能加密
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public Task<ArchiveKeyResponse> ArchiveKey(ArchiveKeyRequest req)
        {
            return InternalRequestAsync<ArchiveKeyResponse>(req, "ArchiveKey");
        }

        /// <summary>
        /// 对密钥进行归档，被归档的密钥只能用于解密，不能加密
        /// </summary>
        /// <param name="req"><see cref="ArchiveKeyRequest"/></param>
        /// <returns><see cref="ArchiveKeyResponse"/></returns>
        public ArchiveKeyResponse ArchiveKeySync(ArchiveKeyRequest req)
        {
            return InternalRequestAsync<ArchiveKeyResponse>(req, "ArchiveKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用指定的RSA非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public Task<AsymmetricRsaDecryptResponse> AsymmetricRsaDecrypt(AsymmetricRsaDecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricRsaDecryptResponse>(req, "AsymmetricRsaDecrypt");
        }

        /// <summary>
        /// 使用指定的RSA非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public AsymmetricRsaDecryptResponse AsymmetricRsaDecryptSync(AsymmetricRsaDecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricRsaDecryptResponse>(req, "AsymmetricRsaDecrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用指定的SM2非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。传入的密文的长度不能超过256字节。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public Task<AsymmetricSm2DecryptResponse> AsymmetricSm2Decrypt(AsymmetricSm2DecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricSm2DecryptResponse>(req, "AsymmetricSm2Decrypt");
        }

        /// <summary>
        /// 使用指定的SM2非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。传入的密文的长度不能超过256字节。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public AsymmetricSm2DecryptResponse AsymmetricSm2DecryptSync(AsymmetricSm2DecryptRequest req)
        {
            return InternalRequestAsync<AsymmetricSm2DecryptResponse>(req, "AsymmetricSm2Decrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 记录当前key被哪个云产品的那个资源所使用。如果当前key设置了自动过期，则取消该设置，确保当前key不会自动失效。如果当前关联关系已经创建，也返回成功。
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public Task<BindCloudResourceResponse> BindCloudResource(BindCloudResourceRequest req)
        {
            return InternalRequestAsync<BindCloudResourceResponse>(req, "BindCloudResource");
        }

        /// <summary>
        /// 记录当前key被哪个云产品的那个资源所使用。如果当前key设置了自动过期，则取消该设置，确保当前key不会自动失效。如果当前关联关系已经创建，也返回成功。
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public BindCloudResourceResponse BindCloudResourceSync(BindCloudResourceRequest req)
        {
            return InternalRequestAsync<BindCloudResourceResponse>(req, "BindCloudResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消密钥归档，取消后密钥的状态变为Enabled。
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public Task<CancelKeyArchiveResponse> CancelKeyArchive(CancelKeyArchiveRequest req)
        {
            return InternalRequestAsync<CancelKeyArchiveResponse>(req, "CancelKeyArchive");
        }

        /// <summary>
        /// 取消密钥归档，取消后密钥的状态变为Enabled。
        /// </summary>
        /// <param name="req"><see cref="CancelKeyArchiveRequest"/></param>
        /// <returns><see cref="CancelKeyArchiveResponse"/></returns>
        public CancelKeyArchiveResponse CancelKeyArchiveSync(CancelKeyArchiveRequest req)
        {
            return InternalRequestAsync<CancelKeyArchiveResponse>(req, "CancelKeyArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public Task<CancelKeyDeletionResponse> CancelKeyDeletion(CancelKeyDeletionRequest req)
        {
            return InternalRequestAsync<CancelKeyDeletionResponse>(req, "CancelKeyDeletion");
        }

        /// <summary>
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public CancelKeyDeletionResponse CancelKeyDeletionSync(CancelKeyDeletionRequest req)
        {
            return InternalRequestAsync<CancelKeyDeletionResponse>(req, "CancelKeyDeletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public Task<CreateKeyResponse> CreateKey(CreateKeyRequest req)
        {
            return InternalRequestAsync<CreateKeyResponse>(req, "CreateKey");
        }

        /// <summary>
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public CreateKeyResponse CreateKeySync(CreateKeyRequest req)
        {
            return InternalRequestAsync<CreateKeyResponse>(req, "CreateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建白盒密钥。 密钥个数的上限为 50。
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public Task<CreateWhiteBoxKeyResponse> CreateWhiteBoxKey(CreateWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<CreateWhiteBoxKeyResponse>(req, "CreateWhiteBoxKey");
        }

        /// <summary>
        /// 创建白盒密钥。 密钥个数的上限为 50。
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public CreateWhiteBoxKeyResponse CreateWhiteBoxKeySync(CreateWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<CreateWhiteBoxKeyResponse>(req, "CreateWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public Task<DecryptResponse> Decrypt(DecryptRequest req)
        {
            return InternalRequestAsync<DecryptResponse>(req, "Decrypt");
        }

        /// <summary>
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public DecryptResponse DecryptSync(DecryptRequest req)
        {
            return InternalRequestAsync<DecryptResponse>(req, "Decrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除导入的密钥材料，仅对EXTERNAL类型的CMK有效，该接口将CMK设置为PendingImport 状态，并不会删除CMK，在重新进行密钥导入后可继续使用。彻底删除CMK请使用 ScheduleKeyDeletion 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest req)
        {
            return InternalRequestAsync<DeleteImportedKeyMaterialResponse>(req, "DeleteImportedKeyMaterial");
        }

        /// <summary>
        /// 用于删除导入的密钥材料，仅对EXTERNAL类型的CMK有效，该接口将CMK设置为PendingImport 状态，并不会删除CMK，在重新进行密钥导入后可继续使用。彻底删除CMK请使用 ScheduleKeyDeletion 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterialSync(DeleteImportedKeyMaterialRequest req)
        {
            return InternalRequestAsync<DeleteImportedKeyMaterialResponse>(req, "DeleteImportedKeyMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除白盒密钥, 注意：必须先禁用后，才可以删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public Task<DeleteWhiteBoxKeyResponse> DeleteWhiteBoxKey(DeleteWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DeleteWhiteBoxKeyResponse>(req, "DeleteWhiteBoxKey");
        }

        /// <summary>
        /// 删除白盒密钥, 注意：必须先禁用后，才可以删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public DeleteWhiteBoxKeyResponse DeleteWhiteBoxKeySync(DeleteWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DeleteWhiteBoxKeyResponse>(req, "DeleteWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public Task<DescribeKeyResponse> DescribeKey(DescribeKeyRequest req)
        {
            return InternalRequestAsync<DescribeKeyResponse>(req, "DescribeKey");
        }

        /// <summary>
        /// 用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public DescribeKeyResponse DescribeKeySync(DescribeKeyRequest req)
        {
            return InternalRequestAsync<DescribeKeyResponse>(req, "DescribeKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys");
        }

        /// <summary>
        /// 该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public DescribeKeysResponse DescribeKeysSync(DescribeKeysRequest req)
        {
            return InternalRequestAsync<DescribeKeysResponse>(req, "DescribeKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取白盒解密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public Task<DescribeWhiteBoxDecryptKeyResponse> DescribeWhiteBoxDecryptKey(DescribeWhiteBoxDecryptKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDecryptKeyResponse>(req, "DescribeWhiteBoxDecryptKey");
        }

        /// <summary>
        /// 获取白盒解密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public DescribeWhiteBoxDecryptKeyResponse DescribeWhiteBoxDecryptKeySync(DescribeWhiteBoxDecryptKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDecryptKeyResponse>(req, "DescribeWhiteBoxDecryptKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定密钥的设备指纹列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public Task<DescribeWhiteBoxDeviceFingerprintsResponse> DescribeWhiteBoxDeviceFingerprints(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDeviceFingerprintsResponse>(req, "DescribeWhiteBoxDeviceFingerprints");
        }

        /// <summary>
        /// 获取指定密钥的设备指纹列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public DescribeWhiteBoxDeviceFingerprintsResponse DescribeWhiteBoxDeviceFingerprintsSync(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxDeviceFingerprintsResponse>(req, "DescribeWhiteBoxDeviceFingerprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示白盒密钥的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public Task<DescribeWhiteBoxKeyResponse> DescribeWhiteBoxKey(DescribeWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyResponse>(req, "DescribeWhiteBoxKey");
        }

        /// <summary>
        /// 展示白盒密钥的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public DescribeWhiteBoxKeyResponse DescribeWhiteBoxKeySync(DescribeWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyResponse>(req, "DescribeWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取白盒密钥列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public Task<DescribeWhiteBoxKeyDetailsResponse> DescribeWhiteBoxKeyDetails(DescribeWhiteBoxKeyDetailsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyDetailsResponse>(req, "DescribeWhiteBoxKeyDetails");
        }

        /// <summary>
        /// 获取白盒密钥列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public DescribeWhiteBoxKeyDetailsResponse DescribeWhiteBoxKeyDetailsSync(DescribeWhiteBoxKeyDetailsRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxKeyDetailsResponse>(req, "DescribeWhiteBoxKeyDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取白盒密钥服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public Task<DescribeWhiteBoxServiceStatusResponse> DescribeWhiteBoxServiceStatus(DescribeWhiteBoxServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxServiceStatusResponse>(req, "DescribeWhiteBoxServiceStatus");
        }

        /// <summary>
        /// 获取白盒密钥服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public DescribeWhiteBoxServiceStatusResponse DescribeWhiteBoxServiceStatusSync(DescribeWhiteBoxServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeWhiteBoxServiceStatusResponse>(req, "DescribeWhiteBoxServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public Task<DisableKeyResponse> DisableKey(DisableKeyRequest req)
        {
            return InternalRequestAsync<DisableKeyResponse>(req, "DisableKey");
        }

        /// <summary>
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public DisableKeyResponse DisableKeySync(DisableKeyRequest req)
        {
            return InternalRequestAsync<DisableKeyResponse>(req, "DisableKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public Task<DisableKeyRotationResponse> DisableKeyRotation(DisableKeyRotationRequest req)
        {
            return InternalRequestAsync<DisableKeyRotationResponse>(req, "DisableKeyRotation");
        }

        /// <summary>
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public DisableKeyRotationResponse DisableKeyRotationSync(DisableKeyRotationRequest req)
        {
            return InternalRequestAsync<DisableKeyRotationResponse>(req, "DisableKeyRotation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public Task<DisableKeysResponse> DisableKeys(DisableKeysRequest req)
        {
            return InternalRequestAsync<DisableKeysResponse>(req, "DisableKeys");
        }

        /// <summary>
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public DisableKeysResponse DisableKeysSync(DisableKeysRequest req)
        {
            return InternalRequestAsync<DisableKeysResponse>(req, "DisableKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public Task<DisableWhiteBoxKeyResponse> DisableWhiteBoxKey(DisableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeyResponse>(req, "DisableWhiteBoxKey");
        }

        /// <summary>
        /// 禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public DisableWhiteBoxKeyResponse DisableWhiteBoxKeySync(DisableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeyResponse>(req, "DisableWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public Task<DisableWhiteBoxKeysResponse> DisableWhiteBoxKeys(DisableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeysResponse>(req, "DisableWhiteBoxKeys");
        }

        /// <summary>
        /// 批量禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public DisableWhiteBoxKeysResponse DisableWhiteBoxKeysSync(DisableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<DisableWhiteBoxKeysResponse>(req, "DisableWhiteBoxKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public Task<EnableKeyResponse> EnableKey(EnableKeyRequest req)
        {
            return InternalRequestAsync<EnableKeyResponse>(req, "EnableKey");
        }

        /// <summary>
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public EnableKeyResponse EnableKeySync(EnableKeyRequest req)
        {
            return InternalRequestAsync<EnableKeyResponse>(req, "EnableKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public Task<EnableKeyRotationResponse> EnableKeyRotation(EnableKeyRotationRequest req)
        {
            return InternalRequestAsync<EnableKeyRotationResponse>(req, "EnableKeyRotation");
        }

        /// <summary>
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public EnableKeyRotationResponse EnableKeyRotationSync(EnableKeyRotationRequest req)
        {
            return InternalRequestAsync<EnableKeyRotationResponse>(req, "EnableKeyRotation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public Task<EnableKeysResponse> EnableKeys(EnableKeysRequest req)
        {
            return InternalRequestAsync<EnableKeysResponse>(req, "EnableKeys");
        }

        /// <summary>
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public EnableKeysResponse EnableKeysSync(EnableKeysRequest req)
        {
            return InternalRequestAsync<EnableKeysResponse>(req, "EnableKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public Task<EnableWhiteBoxKeyResponse> EnableWhiteBoxKey(EnableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeyResponse>(req, "EnableWhiteBoxKey");
        }

        /// <summary>
        /// 启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public EnableWhiteBoxKeyResponse EnableWhiteBoxKeySync(EnableWhiteBoxKeyRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeyResponse>(req, "EnableWhiteBoxKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public Task<EnableWhiteBoxKeysResponse> EnableWhiteBoxKeys(EnableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeysResponse>(req, "EnableWhiteBoxKeys");
        }

        /// <summary>
        /// 批量启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public EnableWhiteBoxKeysResponse EnableWhiteBoxKeysSync(EnableWhiteBoxKeysRequest req)
        {
            return InternalRequestAsync<EnableWhiteBoxKeysResponse>(req, "EnableWhiteBoxKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public Task<EncryptResponse> Encrypt(EncryptRequest req)
        {
            return InternalRequestAsync<EncryptResponse>(req, "Encrypt");
        }

        /// <summary>
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public EncryptResponse EncryptSync(EncryptRequest req)
        {
            return InternalRequestAsync<EncryptResponse>(req, "Encrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用白盒密钥进行加密
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public Task<EncryptByWhiteBoxResponse> EncryptByWhiteBox(EncryptByWhiteBoxRequest req)
        {
            return InternalRequestAsync<EncryptByWhiteBoxResponse>(req, "EncryptByWhiteBox");
        }

        /// <summary>
        /// 使用白盒密钥进行加密
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public EncryptByWhiteBoxResponse EncryptByWhiteBoxSync(EncryptByWhiteBoxRequest req)
        {
            return InternalRequestAsync<EncryptByWhiteBoxResponse>(req, "EncryptByWhiteBox")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public Task<GenerateDataKeyResponse> GenerateDataKey(GenerateDataKeyRequest req)
        {
            return InternalRequestAsync<GenerateDataKeyResponse>(req, "GenerateDataKey");
        }

        /// <summary>
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public GenerateDataKeyResponse GenerateDataKeySync(GenerateDataKeyRequest req)
        {
            return InternalRequestAsync<GenerateDataKeyResponse>(req, "GenerateDataKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 随机数生成接口。
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public Task<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest req)
        {
            return InternalRequestAsync<GenerateRandomResponse>(req, "GenerateRandom");
        }

        /// <summary>
        /// 随机数生成接口。
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public GenerateRandomResponse GenerateRandomSync(GenerateRandomRequest req)
        {
            return InternalRequestAsync<GenerateRandomResponse>(req, "GenerateRandom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public Task<GetKeyRotationStatusResponse> GetKeyRotationStatus(GetKeyRotationStatusRequest req)
        {
            return InternalRequestAsync<GetKeyRotationStatusResponse>(req, "GetKeyRotationStatus");
        }

        /// <summary>
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public GetKeyRotationStatusResponse GetKeyRotationStatusSync(GetKeyRotationStatusRequest req)
        {
            return InternalRequestAsync<GetKeyRotationStatusResponse>(req, "GetKeyRotationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取导入主密钥（CMK）材料的参数，返回的Token作为执行ImportKeyMaterial的参数之一，返回的PublicKey用于对自主导入密钥材料进行加密。返回的Token和PublicKey 24小时后失效，失效后如需重新导入，需要再次调用该接口获取新的Token和PublicKey。
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public Task<GetParametersForImportResponse> GetParametersForImport(GetParametersForImportRequest req)
        {
            return InternalRequestAsync<GetParametersForImportResponse>(req, "GetParametersForImport");
        }

        /// <summary>
        /// 获取导入主密钥（CMK）材料的参数，返回的Token作为执行ImportKeyMaterial的参数之一，返回的PublicKey用于对自主导入密钥材料进行加密。返回的Token和PublicKey 24小时后失效，失效后如需重新导入，需要再次调用该接口获取新的Token和PublicKey。
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public GetParametersForImportResponse GetParametersForImportSync(GetParametersForImportRequest req)
        {
            return InternalRequestAsync<GetParametersForImportResponse>(req, "GetParametersForImport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于获取非对称密钥的公钥信息，可用于本地数据加密或验签。只有处于Enabled状态的非对称密钥才可能获取公钥。
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey");
        }

        /// <summary>
        /// 该接口用于获取非对称密钥的公钥信息，可用于本地数据加密或验签。只有处于Enabled状态的非对称密钥才可能获取公钥。
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取可以提供KMS服务的地域列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions");
        }

        /// <summary>
        /// 获取可以提供KMS服务的地域列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
            return InternalRequestAsync<GetRegionsResponse>(req, "GetRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus");
        }

        /// <summary>
        /// 用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
            return InternalRequestAsync<GetServiceStatusResponse>(req, "GetServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于导入密钥材料。只有类型为EXTERNAL 的CMK 才可以导入，导入的密钥材料使用 GetParametersForImport 获取的密钥进行加密。可以为指定的 CMK 重新导入密钥材料，并重新指定过期时间，但必须导入相同的密钥材料。CMK 密钥材料导入后不可以更换密钥材料。导入的密钥材料过期或者被删除后，指定的CMK将无法使用，需要再次导入相同的密钥材料才能正常使用。CMK是独立的，同样的密钥材料可导入不同的 CMK 中，但使用其中一个 CMK 加密的数据无法使用另一个 CMK解密。
        /// 只有Enabled 和 PendingImport状态的CMK可以导入密钥材料。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public Task<ImportKeyMaterialResponse> ImportKeyMaterial(ImportKeyMaterialRequest req)
        {
            return InternalRequestAsync<ImportKeyMaterialResponse>(req, "ImportKeyMaterial");
        }

        /// <summary>
        /// 用于导入密钥材料。只有类型为EXTERNAL 的CMK 才可以导入，导入的密钥材料使用 GetParametersForImport 获取的密钥进行加密。可以为指定的 CMK 重新导入密钥材料，并重新指定过期时间，但必须导入相同的密钥材料。CMK 密钥材料导入后不可以更换密钥材料。导入的密钥材料过期或者被删除后，指定的CMK将无法使用，需要再次导入相同的密钥材料才能正常使用。CMK是独立的，同样的密钥材料可导入不同的 CMK 中，但使用其中一个 CMK 加密的数据无法使用另一个 CMK解密。
        /// 只有Enabled 和 PendingImport状态的CMK可以导入密钥材料。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public ImportKeyMaterialResponse ImportKeyMaterialSync(ImportKeyMaterialRequest req)
        {
            return InternalRequestAsync<ImportKeyMaterialResponse>(req, "ImportKeyMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出当前Region支持的加密方式
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public Task<ListAlgorithmsResponse> ListAlgorithms(ListAlgorithmsRequest req)
        {
            return InternalRequestAsync<ListAlgorithmsResponse>(req, "ListAlgorithms");
        }

        /// <summary>
        /// 列出当前Region支持的加密方式
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public ListAlgorithmsResponse ListAlgorithmsSync(ListAlgorithmsRequest req)
        {
            return InternalRequestAsync<ListAlgorithmsResponse>(req, "ListAlgorithms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public Task<ListKeyDetailResponse> ListKeyDetail(ListKeyDetailRequest req)
        {
            return InternalRequestAsync<ListKeyDetailResponse>(req, "ListKeyDetail");
        }

        /// <summary>
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public ListKeyDetailResponse ListKeyDetailSync(ListKeyDetailRequest req)
        {
            return InternalRequestAsync<ListKeyDetailResponse>(req, "ListKeyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出账号下面状态为Enabled， Disabled 和 PendingImport 的CMK KeyId 列表
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public Task<ListKeysResponse> ListKeys(ListKeysRequest req)
        {
            return InternalRequestAsync<ListKeysResponse>(req, "ListKeys");
        }

        /// <summary>
        /// 列出账号下面状态为Enabled， Disabled 和 PendingImport 的CMK KeyId 列表
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public ListKeysResponse ListKeysSync(ListKeysRequest req)
        {
            return InternalRequestAsync<ListKeysResponse>(req, "ListKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 覆盖指定密钥的设备指纹信息
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public Task<OverwriteWhiteBoxDeviceFingerprintsResponse> OverwriteWhiteBoxDeviceFingerprints(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<OverwriteWhiteBoxDeviceFingerprintsResponse>(req, "OverwriteWhiteBoxDeviceFingerprints");
        }

        /// <summary>
        /// 覆盖指定密钥的设备指纹信息
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public OverwriteWhiteBoxDeviceFingerprintsResponse OverwriteWhiteBoxDeviceFingerprintsSync(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
            return InternalRequestAsync<OverwriteWhiteBoxDeviceFingerprintsResponse>(req, "OverwriteWhiteBoxDeviceFingerprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口使用后量子密码算法密钥，解密密文，并得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoDecryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoDecryptResponse"/></returns>
        public Task<PostQuantumCryptoDecryptResponse> PostQuantumCryptoDecrypt(PostQuantumCryptoDecryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoDecryptResponse>(req, "PostQuantumCryptoDecrypt");
        }

        /// <summary>
        /// 本接口使用后量子密码算法密钥，解密密文，并得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoDecryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoDecryptResponse"/></returns>
        public PostQuantumCryptoDecryptResponse PostQuantumCryptoDecryptSync(PostQuantumCryptoDecryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoDecryptResponse>(req, "PostQuantumCryptoDecrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口使用后量子密码算法密钥，可加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoEncryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoEncryptResponse"/></returns>
        public Task<PostQuantumCryptoEncryptResponse> PostQuantumCryptoEncrypt(PostQuantumCryptoEncryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoEncryptResponse>(req, "PostQuantumCryptoEncrypt");
        }

        /// <summary>
        /// 本接口使用后量子密码算法密钥，可加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoEncryptRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoEncryptResponse"/></returns>
        public PostQuantumCryptoEncryptResponse PostQuantumCryptoEncryptSync(PostQuantumCryptoEncryptRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoEncryptResponse>(req, "PostQuantumCryptoEncrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用后量子密码算法签名验签密钥进行签名。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoSignRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoSignResponse"/></returns>
        public Task<PostQuantumCryptoSignResponse> PostQuantumCryptoSign(PostQuantumCryptoSignRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoSignResponse>(req, "PostQuantumCryptoSign");
        }

        /// <summary>
        /// 使用后量子密码算法签名验签密钥进行签名。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoSignRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoSignResponse"/></returns>
        public PostQuantumCryptoSignResponse PostQuantumCryptoSignSync(PostQuantumCryptoSignRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoSignResponse>(req, "PostQuantumCryptoSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用后量子密码算法密钥对签名进行验证。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoVerifyRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoVerifyResponse"/></returns>
        public Task<PostQuantumCryptoVerifyResponse> PostQuantumCryptoVerify(PostQuantumCryptoVerifyRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoVerifyResponse>(req, "PostQuantumCryptoVerify");
        }

        /// <summary>
        /// 使用后量子密码算法密钥对签名进行验证。
        /// </summary>
        /// <param name="req"><see cref="PostQuantumCryptoVerifyRequest"/></param>
        /// <returns><see cref="PostQuantumCryptoVerifyResponse"/></returns>
        public PostQuantumCryptoVerifyResponse PostQuantumCryptoVerifySync(PostQuantumCryptoVerifyRequest req)
        {
            return InternalRequestAsync<PostQuantumCryptoVerifyResponse>(req, "PostQuantumCryptoVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public Task<ReEncryptResponse> ReEncrypt(ReEncryptRequest req)
        {
            return InternalRequestAsync<ReEncryptResponse>(req, "ReEncrypt");
        }

        /// <summary>
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public ReEncryptResponse ReEncryptSync(ReEncryptRequest req)
        {
            return InternalRequestAsync<ReEncryptResponse>(req, "ReEncrypt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletion(ScheduleKeyDeletionRequest req)
        {
            return InternalRequestAsync<ScheduleKeyDeletionResponse>(req, "ScheduleKeyDeletion");
        }

        /// <summary>
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletionSync(ScheduleKeyDeletionRequest req)
        {
            return InternalRequestAsync<ScheduleKeyDeletionResponse>(req, "ScheduleKeyDeletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 非对称密钥签名。
        /// 注意：只有 KeyUsage 为 ASYMMETRIC_SIGN_VERIFY_SM2、ASYMMETRIC_SIGN_VERIFY_ECC 或其他支持的 ASYMMETRIC_SIGN_VERIFY_${ALGORITHM} 的密钥才可以使用签名功能。
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public Task<SignByAsymmetricKeyResponse> SignByAsymmetricKey(SignByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<SignByAsymmetricKeyResponse>(req, "SignByAsymmetricKey");
        }

        /// <summary>
        /// 非对称密钥签名。
        /// 注意：只有 KeyUsage 为 ASYMMETRIC_SIGN_VERIFY_SM2、ASYMMETRIC_SIGN_VERIFY_ECC 或其他支持的 ASYMMETRIC_SIGN_VERIFY_${ALGORITHM} 的密钥才可以使用签名功能。
        /// </summary>
        /// <param name="req"><see cref="SignByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="SignByAsymmetricKeyResponse"/></returns>
        public SignByAsymmetricKeyResponse SignByAsymmetricKeySync(SignByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<SignByAsymmetricKeyResponse>(req, "SignByAsymmetricKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定（key, 资源，云产品）的记录，以表明：指定的云产品的资源已不再使用当前的key。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public Task<UnbindCloudResourceResponse> UnbindCloudResource(UnbindCloudResourceRequest req)
        {
            return InternalRequestAsync<UnbindCloudResourceResponse>(req, "UnbindCloudResource");
        }

        /// <summary>
        /// 删除指定（key, 资源，云产品）的记录，以表明：指定的云产品的资源已不再使用当前的key。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public UnbindCloudResourceResponse UnbindCloudResourceSync(UnbindCloudResourceRequest req)
        {
            return InternalRequestAsync<UnbindCloudResourceResponse>(req, "UnbindCloudResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改CMK的别名。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias");
        }

        /// <summary>
        /// 用于修改CMK的别名。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于对指定的cmk修改描述信息。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public Task<UpdateKeyDescriptionResponse> UpdateKeyDescription(UpdateKeyDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateKeyDescriptionResponse>(req, "UpdateKeyDescription");
        }

        /// <summary>
        /// 该接口用于对指定的cmk修改描述信息。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public UpdateKeyDescriptionResponse UpdateKeyDescriptionSync(UpdateKeyDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateKeyDescriptionResponse>(req, "UpdateKeyDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用非对称密钥验签
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public Task<VerifyByAsymmetricKeyResponse> VerifyByAsymmetricKey(VerifyByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<VerifyByAsymmetricKeyResponse>(req, "VerifyByAsymmetricKey");
        }

        /// <summary>
        /// 使用非对称密钥验签
        /// </summary>
        /// <param name="req"><see cref="VerifyByAsymmetricKeyRequest"/></param>
        /// <returns><see cref="VerifyByAsymmetricKeyResponse"/></returns>
        public VerifyByAsymmetricKeyResponse VerifyByAsymmetricKeySync(VerifyByAsymmetricKeyRequest req)
        {
            return InternalRequestAsync<VerifyByAsymmetricKeyResponse>(req, "VerifyByAsymmetricKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
