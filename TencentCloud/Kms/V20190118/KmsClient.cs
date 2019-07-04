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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public KmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public KmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req">参考<see cref="CancelKeyDeletionRequest"/></param>
        /// <returns>参考<see cref="CancelKeyDeletionResponse"/>实例</returns>
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
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req">参考<see cref="CreateKeyRequest"/></param>
        /// <returns>参考<see cref="CreateKeyResponse"/>实例</returns>
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
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req">参考<see cref="DecryptRequest"/></param>
        /// <returns>参考<see cref="DecryptResponse"/>实例</returns>
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
        /// 用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeKeyResponse"/>实例</returns>
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
        /// 该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeysRequest"/></param>
        /// <returns>参考<see cref="DescribeKeysResponse"/>实例</returns>
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
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeyRequest"/></param>
        /// <returns>参考<see cref="DisableKeyResponse"/>实例</returns>
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
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeyRotationRequest"/></param>
        /// <returns>参考<see cref="DisableKeyRotationResponse"/>实例</returns>
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
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req">参考<see cref="DisableKeysRequest"/></param>
        /// <returns>参考<see cref="DisableKeysResponse"/>实例</returns>
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
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeyRequest"/></param>
        /// <returns>参考<see cref="EnableKeyResponse"/>实例</returns>
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
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeyRotationRequest"/></param>
        /// <returns>参考<see cref="EnableKeyRotationResponse"/>实例</returns>
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
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req">参考<see cref="EnableKeysRequest"/></param>
        /// <returns>参考<see cref="EnableKeysResponse"/>实例</returns>
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
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req">参考<see cref="EncryptRequest"/></param>
        /// <returns>参考<see cref="EncryptResponse"/>实例</returns>
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
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req">参考<see cref="GenerateDataKeyRequest"/></param>
        /// <returns>参考<see cref="GenerateDataKeyResponse"/>实例</returns>
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
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req">参考<see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns>参考<see cref="GetKeyRotationStatusResponse"/>实例</returns>
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
        /// 用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req">参考<see cref="GetServiceStatusRequest"/></param>
        /// <returns>参考<see cref="GetServiceStatusResponse"/>实例</returns>
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
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req">参考<see cref="ListKeyDetailRequest"/></param>
        /// <returns>参考<see cref="ListKeyDetailResponse"/>实例</returns>
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
        /// 列出账号下面的密钥列表（KeyId信息）。
        /// </summary>
        /// <param name="req">参考<see cref="ListKeysRequest"/></param>
        /// <returns>参考<see cref="ListKeysResponse"/>实例</returns>
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
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req">参考<see cref="ReEncryptRequest"/></param>
        /// <returns>参考<see cref="ReEncryptResponse"/>实例</returns>
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
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req">参考<see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns>参考<see cref="ScheduleKeyDeletionResponse"/>实例</returns>
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
        /// 用于修改CMK的别名。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateAliasRequest"/></param>
        /// <returns>参考<see cref="UpdateAliasResponse"/>实例</returns>
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
        /// 该接口用于对指定的cmk修改描述信息。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns>参考<see cref="UpdateKeyDescriptionResponse"/>实例</returns>
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

    }
}
