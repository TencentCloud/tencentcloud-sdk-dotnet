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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletion(CancelKeyDeletionRequest req)
        {
             JsonResponseModel<CancelKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CancelKeyDeletion接口的同步版本，取消CMK的计划删除操作
        /// </summary>
        /// <param name="req">参考<see cref="CancelKeyDeletionRequest"/></param>
        /// <returns>参考<see cref="CancelKeyDeletionResponse"/>实例</returns>
        public CancelKeyDeletionResponse CancelKeyDeletionSync(CancelKeyDeletionRequest req)
        {
             JsonResponseModel<CancelKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
        public async Task<CreateKeyResponse> CreateKey(CreateKeyRequest req)
        {
             JsonResponseModel<CreateKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateKey接口的同步版本，创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req">参考<see cref="CreateKeyRequest"/></param>
        /// <returns>参考<see cref="CreateKeyResponse"/>实例</returns>
        public CreateKeyResponse CreateKeySync(CreateKeyRequest req)
        {
             JsonResponseModel<CreateKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
        public async Task<DecryptResponse> Decrypt(DecryptRequest req)
        {
             JsonResponseModel<DecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Decrypt接口的同步版本，本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req">参考<see cref="DecryptRequest"/></param>
        /// <returns>参考<see cref="DecryptResponse"/>实例</returns>
        public DecryptResponse DecryptSync(DecryptRequest req)
        {
             JsonResponseModel<DecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除导入的密钥材料，仅对EXTERNAL类型的CMK有效，该接口将CMK设置为PendingImport 状态，并不会删除CMK，在重新进行密钥导入后可继续使用。彻底删除CMK请使用 ScheduleKeyDeletion 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
        public async Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest req)
        {
             JsonResponseModel<DeleteImportedKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImportedKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImportedKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteImportedKeyMaterial接口的同步版本，用于删除导入的密钥材料，仅对EXTERNAL类型的CMK有效，该接口将CMK设置为PendingImport 状态，并不会删除CMK，在重新进行密钥导入后可继续使用。彻底删除CMK请使用 ScheduleKeyDeletion 接口。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns>参考<see cref="DeleteImportedKeyMaterialResponse"/>实例</returns>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterialSync(DeleteImportedKeyMaterialRequest req)
        {
             JsonResponseModel<DeleteImportedKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImportedKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImportedKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
        public async Task<DescribeKeyResponse> DescribeKey(DescribeKeyRequest req)
        {
             JsonResponseModel<DescribeKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeKey接口的同步版本，用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeKeyResponse"/>实例</returns>
        public DescribeKeyResponse DescribeKeySync(DescribeKeyRequest req)
        {
             JsonResponseModel<DescribeKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
        public async Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
             JsonResponseModel<DescribeKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeKeys接口的同步版本，该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeysRequest"/></param>
        /// <returns>参考<see cref="DescribeKeysResponse"/>实例</returns>
        public DescribeKeysResponse DescribeKeysSync(DescribeKeysRequest req)
        {
             JsonResponseModel<DescribeKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
        public async Task<DisableKeyResponse> DisableKey(DisableKeyRequest req)
        {
             JsonResponseModel<DisableKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableKey接口的同步版本，本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeyRequest"/></param>
        /// <returns>参考<see cref="DisableKeyResponse"/>实例</returns>
        public DisableKeyResponse DisableKeySync(DisableKeyRequest req)
        {
             JsonResponseModel<DisableKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
        public async Task<DisableKeyRotationResponse> DisableKeyRotation(DisableKeyRotationRequest req)
        {
             JsonResponseModel<DisableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableKeyRotation接口的同步版本，对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeyRotationRequest"/></param>
        /// <returns>参考<see cref="DisableKeyRotationResponse"/>实例</returns>
        public DisableKeyRotationResponse DisableKeyRotationSync(DisableKeyRotationRequest req)
        {
             JsonResponseModel<DisableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
        public async Task<DisableKeysResponse> DisableKeys(DisableKeysRequest req)
        {
             JsonResponseModel<DisableKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableKeys接口的同步版本，该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeysRequest"/></param>
        /// <returns>参考<see cref="DisableKeysResponse"/>实例</returns>
        public DisableKeysResponse DisableKeysSync(DisableKeysRequest req)
        {
             JsonResponseModel<DisableKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
        public async Task<EnableKeyResponse> EnableKey(EnableKeyRequest req)
        {
             JsonResponseModel<EnableKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableKey接口的同步版本，用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeyRequest"/></param>
        /// <returns>参考<see cref="EnableKeyResponse"/>实例</returns>
        public EnableKeyResponse EnableKeySync(EnableKeyRequest req)
        {
             JsonResponseModel<EnableKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
        public async Task<EnableKeyRotationResponse> EnableKeyRotation(EnableKeyRotationRequest req)
        {
             JsonResponseModel<EnableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableKeyRotation接口的同步版本，对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeyRotationRequest"/></param>
        /// <returns>参考<see cref="EnableKeyRotationResponse"/>实例</returns>
        public EnableKeyRotationResponse EnableKeyRotationSync(EnableKeyRotationRequest req)
        {
             JsonResponseModel<EnableKeyRotationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKeyRotation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeyRotationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
        public async Task<EnableKeysResponse> EnableKeys(EnableKeysRequest req)
        {
             JsonResponseModel<EnableKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableKeys接口的同步版本，该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeysRequest"/></param>
        /// <returns>参考<see cref="EnableKeysResponse"/>实例</returns>
        public EnableKeysResponse EnableKeysSync(EnableKeysRequest req)
        {
             JsonResponseModel<EnableKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
        public async Task<EncryptResponse> Encrypt(EncryptRequest req)
        {
             JsonResponseModel<EncryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Encrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Encrypt接口的同步版本，本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req">参考<see cref="EncryptRequest"/></param>
        /// <returns>参考<see cref="EncryptResponse"/>实例</returns>
        public EncryptResponse EncryptSync(EncryptRequest req)
        {
             JsonResponseModel<EncryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Encrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
        public async Task<GenerateDataKeyResponse> GenerateDataKey(GenerateDataKeyRequest req)
        {
             JsonResponseModel<GenerateDataKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateDataKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDataKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GenerateDataKey接口的同步版本，本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req">参考<see cref="GenerateDataKeyRequest"/></param>
        /// <returns>参考<see cref="GenerateDataKeyResponse"/>实例</returns>
        public GenerateDataKeyResponse GenerateDataKeySync(GenerateDataKeyRequest req)
        {
             JsonResponseModel<GenerateDataKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateDataKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDataKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 随机数生成接口。
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
        public async Task<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest req)
        {
             JsonResponseModel<GenerateRandomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateRandom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateRandomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GenerateRandom接口的同步版本，随机数生成接口。
        /// </summary>
        /// <param name="req">参考<see cref="GenerateRandomRequest"/></param>
        /// <returns>参考<see cref="GenerateRandomResponse"/>实例</returns>
        public GenerateRandomResponse GenerateRandomSync(GenerateRandomRequest req)
        {
             JsonResponseModel<GenerateRandomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateRandom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateRandomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
        public async Task<GetKeyRotationStatusResponse> GetKeyRotationStatus(GetKeyRotationStatusRequest req)
        {
             JsonResponseModel<GetKeyRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetKeyRotationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetKeyRotationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetKeyRotationStatus接口的同步版本，查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns>参考<see cref="GetKeyRotationStatusResponse"/>实例</returns>
        public GetKeyRotationStatusResponse GetKeyRotationStatusSync(GetKeyRotationStatusRequest req)
        {
             JsonResponseModel<GetKeyRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetKeyRotationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetKeyRotationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取导入主密钥（CMK）材料的参数，返回的Token作为执行ImportKeyMaterial的参数之一，返回的PublicKey用于对自主导入密钥材料进行加密。返回的Token和PublicKey 24小时后失效，失效后如需重新导入，需要再次调用该接口获取新的Token和PublicKey。
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
        public async Task<GetParametersForImportResponse> GetParametersForImport(GetParametersForImportRequest req)
        {
             JsonResponseModel<GetParametersForImportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetParametersForImport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetParametersForImportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetParametersForImport接口的同步版本，获取导入主密钥（CMK）材料的参数，返回的Token作为执行ImportKeyMaterial的参数之一，返回的PublicKey用于对自主导入密钥材料进行加密。返回的Token和PublicKey 24小时后失效，失效后如需重新导入，需要再次调用该接口获取新的Token和PublicKey。
        /// </summary>
        /// <param name="req">参考<see cref="GetParametersForImportRequest"/></param>
        /// <returns>参考<see cref="GetParametersForImportResponse"/>实例</returns>
        public GetParametersForImportResponse GetParametersForImportSync(GetParametersForImportRequest req)
        {
             JsonResponseModel<GetParametersForImportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetParametersForImport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetParametersForImportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public async Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetServiceStatus接口的同步版本，用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req">参考<see cref="GetServiceStatusRequest"/></param>
        /// <returns>参考<see cref="GetServiceStatusResponse"/>实例</returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于导入密钥材料。只有类型为EXTERNAL 的CMK 才可以导入，导入的密钥材料使用 GetParametersForImport 获取的密钥进行加密。可以为指定的 CMK 重新导入密钥材料，并重新指定过期时间，但必须导入相同的密钥材料。CMK 密钥材料导入后不可以更换密钥材料。导入的密钥材料过期或者被删除后，指定的CMK将无法使用，需要再次导入相同的密钥材料才能正常使用。CMK是独立的，同样的密钥材料可导入不同的 CMK 中，但使用其中一个 CMK 加密的数据无法使用另一个 CMK解密。
        /// 只有Enabled 和 PendingImport状态的CMK可以导入密钥材料。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterial(ImportKeyMaterialRequest req)
        {
             JsonResponseModel<ImportKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ImportKeyMaterial接口的同步版本，用于导入密钥材料。只有类型为EXTERNAL 的CMK 才可以导入，导入的密钥材料使用 GetParametersForImport 获取的密钥进行加密。可以为指定的 CMK 重新导入密钥材料，并重新指定过期时间，但必须导入相同的密钥材料。CMK 密钥材料导入后不可以更换密钥材料。导入的密钥材料过期或者被删除后，指定的CMK将无法使用，需要再次导入相同的密钥材料才能正常使用。CMK是独立的，同样的密钥材料可导入不同的 CMK 中，但使用其中一个 CMK 加密的数据无法使用另一个 CMK解密。
        /// 只有Enabled 和 PendingImport状态的CMK可以导入密钥材料。
        /// </summary>
        /// <param name="req">参考<see cref="ImportKeyMaterialRequest"/></param>
        /// <returns>参考<see cref="ImportKeyMaterialResponse"/>实例</returns>
        public ImportKeyMaterialResponse ImportKeyMaterialSync(ImportKeyMaterialRequest req)
        {
             JsonResponseModel<ImportKeyMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
        public async Task<ListKeyDetailResponse> ListKeyDetail(ListKeyDetailRequest req)
        {
             JsonResponseModel<ListKeyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListKeyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListKeyDetail接口的同步版本，根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req">参考<see cref="ListKeyDetailRequest"/></param>
        /// <returns>参考<see cref="ListKeyDetailResponse"/>实例</returns>
        public ListKeyDetailResponse ListKeyDetailSync(ListKeyDetailRequest req)
        {
             JsonResponseModel<ListKeyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListKeyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出账号下面状态为Enabled， Disabled 和 PendingImport 的CMK KeyId 列表
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
        public async Task<ListKeysResponse> ListKeys(ListKeysRequest req)
        {
             JsonResponseModel<ListKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListKeys接口的同步版本，列出账号下面状态为Enabled， Disabled 和 PendingImport 的CMK KeyId 列表
        /// </summary>
        /// <param name="req">参考<see cref="ListKeysRequest"/></param>
        /// <returns>参考<see cref="ListKeysResponse"/>实例</returns>
        public ListKeysResponse ListKeysSync(ListKeysRequest req)
        {
             JsonResponseModel<ListKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
        public async Task<ReEncryptResponse> ReEncrypt(ReEncryptRequest req)
        {
             JsonResponseModel<ReEncryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReEncrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReEncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReEncrypt接口的同步版本，使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req">参考<see cref="ReEncryptRequest"/></param>
        /// <returns>参考<see cref="ReEncryptResponse"/>实例</returns>
        public ReEncryptResponse ReEncryptSync(ReEncryptRequest req)
        {
             JsonResponseModel<ReEncryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReEncrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReEncryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletion(ScheduleKeyDeletionRequest req)
        {
             JsonResponseModel<ScheduleKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScheduleKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScheduleKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ScheduleKeyDeletion接口的同步版本，CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req">参考<see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns>参考<see cref="ScheduleKeyDeletionResponse"/>实例</returns>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletionSync(ScheduleKeyDeletionRequest req)
        {
             JsonResponseModel<ScheduleKeyDeletionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScheduleKeyDeletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScheduleKeyDeletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改CMK的别名。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public async Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateAlias接口的同步版本，用于修改CMK的别名。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateAliasRequest"/></param>
        /// <returns>参考<see cref="UpdateAliasResponse"/>实例</returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于对指定的cmk修改描述信息。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescription(UpdateKeyDescriptionRequest req)
        {
             JsonResponseModel<UpdateKeyDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateKeyDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateKeyDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateKeyDescription接口的同步版本，该接口用于对指定的cmk修改描述信息。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns>参考<see cref="UpdateKeyDescriptionResponse"/>实例</returns>
        public UpdateKeyDescriptionResponse UpdateKeyDescriptionSync(UpdateKeyDescriptionRequest req)
        {
             JsonResponseModel<UpdateKeyDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateKeyDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateKeyDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
