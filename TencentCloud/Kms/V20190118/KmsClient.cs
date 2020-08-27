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
        /// 使用指定的RSA非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public async Task<AsymmetricRsaDecryptResponse> AsymmetricRsaDecrypt(AsymmetricRsaDecryptRequest req)
        {
             JsonResponseModel<AsymmetricRsaDecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AsymmetricRsaDecrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricRsaDecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定的RSA非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricRsaDecryptRequest"/></param>
        /// <returns><see cref="AsymmetricRsaDecryptResponse"/></returns>
        public AsymmetricRsaDecryptResponse AsymmetricRsaDecryptSync(AsymmetricRsaDecryptRequest req)
        {
             JsonResponseModel<AsymmetricRsaDecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AsymmetricRsaDecrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricRsaDecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定的SM2非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。传入的密文的长度不能超过256字节。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public async Task<AsymmetricSm2DecryptResponse> AsymmetricSm2Decrypt(AsymmetricSm2DecryptRequest req)
        {
             JsonResponseModel<AsymmetricSm2DecryptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AsymmetricSm2Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricSm2DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定的SM2非对称密钥的私钥进行数据解密，密文必须是使用对应公钥加密的。处于Enabled 状态的非对称密钥才能进行解密操作。传入的密文的长度不能超过256字节。
        /// </summary>
        /// <param name="req"><see cref="AsymmetricSm2DecryptRequest"/></param>
        /// <returns><see cref="AsymmetricSm2DecryptResponse"/></returns>
        public AsymmetricSm2DecryptResponse AsymmetricSm2DecryptSync(AsymmetricSm2DecryptRequest req)
        {
             JsonResponseModel<AsymmetricSm2DecryptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AsymmetricSm2Decrypt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsymmetricSm2DecryptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 记录当前key被哪个云产品的那个资源所使用。如果当前key设置了自动过期，则取消该设置，确保当前key不会自动失效。如果当前关联关系已经创建，也返回成功。
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public async Task<BindCloudResourceResponse> BindCloudResource(BindCloudResourceRequest req)
        {
             JsonResponseModel<BindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 记录当前key被哪个云产品的那个资源所使用。如果当前key设置了自动过期，则取消该设置，确保当前key不会自动失效。如果当前关联关系已经创建，也返回成功。
        /// </summary>
        /// <param name="req"><see cref="BindCloudResourceRequest"/></param>
        /// <returns><see cref="BindCloudResourceResponse"/></returns>
        public BindCloudResourceResponse BindCloudResourceSync(BindCloudResourceRequest req)
        {
             JsonResponseModel<BindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 取消CMK的计划删除操作
        /// </summary>
        /// <param name="req"><see cref="CancelKeyDeletionRequest"/></param>
        /// <returns><see cref="CancelKeyDeletionResponse"/></returns>
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
        /// 创建用户管理数据密钥的主密钥CMK（Custom Master Key）。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyRequest"/></param>
        /// <returns><see cref="CreateKeyResponse"/></returns>
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
        /// 创建白盒密钥。 密钥个数的上限为 50。
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public async Task<CreateWhiteBoxKeyResponse> CreateWhiteBoxKey(CreateWhiteBoxKeyRequest req)
        {
             JsonResponseModel<CreateWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白盒密钥。 密钥个数的上限为 50。
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="CreateWhiteBoxKeyResponse"/></returns>
        public CreateWhiteBoxKeyResponse CreateWhiteBoxKeySync(CreateWhiteBoxKeyRequest req)
        {
             JsonResponseModel<CreateWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteBoxKeyResponse>>(strResp);
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
        /// 本接口用于解密密文，得到明文数据。
        /// </summary>
        /// <param name="req"><see cref="DecryptRequest"/></param>
        /// <returns><see cref="DecryptResponse"/></returns>
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
        /// 用于删除导入的密钥材料，仅对EXTERNAL类型的CMK有效，该接口将CMK设置为PendingImport 状态，并不会删除CMK，在重新进行密钥导入后可继续使用。彻底删除CMK请使用 ScheduleKeyDeletion 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteImportedKeyMaterialRequest"/></param>
        /// <returns><see cref="DeleteImportedKeyMaterialResponse"/></returns>
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
        /// 删除白盒密钥, 注意：必须先禁用后，才可以删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public async Task<DeleteWhiteBoxKeyResponse> DeleteWhiteBoxKey(DeleteWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DeleteWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除白盒密钥, 注意：必须先禁用后，才可以删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DeleteWhiteBoxKeyResponse"/></returns>
        public DeleteWhiteBoxKeyResponse DeleteWhiteBoxKeySync(DeleteWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DeleteWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhiteBoxKeyResponse>>(strResp);
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
        /// 用于获取指定KeyId的主密钥属性详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyRequest"/></param>
        /// <returns><see cref="DescribeKeyResponse"/></returns>
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
        /// 该接口用于批量获取主密钥属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeysRequest"/></param>
        /// <returns><see cref="DescribeKeysResponse"/></returns>
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
        /// 获取白盒解密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public async Task<DescribeWhiteBoxDecryptKeyResponse> DescribeWhiteBoxDecryptKey(DescribeWhiteBoxDecryptKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxDecryptKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白盒解密密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDecryptKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDecryptKeyResponse"/></returns>
        public DescribeWhiteBoxDecryptKeyResponse DescribeWhiteBoxDecryptKeySync(DescribeWhiteBoxDecryptKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxDecryptKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDecryptKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定密钥的设备指纹列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public async Task<DescribeWhiteBoxDeviceFingerprintsResponse> DescribeWhiteBoxDeviceFingerprints(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定密钥的设备指纹列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxDeviceFingerprintsResponse"/></returns>
        public DescribeWhiteBoxDeviceFingerprintsResponse DescribeWhiteBoxDeviceFingerprintsSync(DescribeWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示白盒密钥的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public async Task<DescribeWhiteBoxKeyResponse> DescribeWhiteBoxKey(DescribeWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示白盒密钥的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyResponse"/></returns>
        public DescribeWhiteBoxKeyResponse DescribeWhiteBoxKeySync(DescribeWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白盒密钥列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public async Task<DescribeWhiteBoxKeyDetailsResponse> DescribeWhiteBoxKeyDetails(DescribeWhiteBoxKeyDetailsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxKeyDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白盒密钥列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxKeyDetailsRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxKeyDetailsResponse"/></returns>
        public DescribeWhiteBoxKeyDetailsResponse DescribeWhiteBoxKeyDetailsSync(DescribeWhiteBoxKeyDetailsRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxKeyDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxKeyDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白盒密钥服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public async Task<DescribeWhiteBoxServiceStatusResponse> DescribeWhiteBoxServiceStatus(DescribeWhiteBoxServiceStatusRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteBoxServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白盒密钥服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteBoxServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeWhiteBoxServiceStatusResponse"/></returns>
        public DescribeWhiteBoxServiceStatusResponse DescribeWhiteBoxServiceStatusSync(DescribeWhiteBoxServiceStatusRequest req)
        {
             JsonResponseModel<DescribeWhiteBoxServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteBoxServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteBoxServiceStatusResponse>>(strResp);
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
        /// 本接口用于禁用一个主密钥，处于禁用状态的Key无法用于加密、解密操作。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRequest"/></param>
        /// <returns><see cref="DisableKeyResponse"/></returns>
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
        /// 对指定的CMK禁止密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="DisableKeyRotationRequest"/></param>
        /// <returns><see cref="DisableKeyRotationResponse"/></returns>
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
        /// 该接口用于批量禁止CMK的使用。
        /// </summary>
        /// <param name="req"><see cref="DisableKeysRequest"/></param>
        /// <returns><see cref="DisableKeysResponse"/></returns>
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
        /// 禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public async Task<DisableWhiteBoxKeyResponse> DisableWhiteBoxKey(DisableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeyResponse"/></returns>
        public DisableWhiteBoxKeyResponse DisableWhiteBoxKeySync(DisableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public async Task<DisableWhiteBoxKeysResponse> DisableWhiteBoxKeys(DisableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量禁用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="DisableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="DisableWhiteBoxKeysResponse"/></returns>
        public DisableWhiteBoxKeysResponse DisableWhiteBoxKeysSync(DisableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<DisableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWhiteBoxKeysResponse>>(strResp);
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
        /// 用于启用一个指定的CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRequest"/></param>
        /// <returns><see cref="EnableKeyResponse"/></returns>
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
        /// 对指定的CMK开启密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="EnableKeyRotationRequest"/></param>
        /// <returns><see cref="EnableKeyRotationResponse"/></returns>
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
        /// 该接口用于批量启用CMK。
        /// </summary>
        /// <param name="req"><see cref="EnableKeysRequest"/></param>
        /// <returns><see cref="EnableKeysResponse"/></returns>
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
        /// 启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public async Task<EnableWhiteBoxKeyResponse> EnableWhiteBoxKey(EnableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeyRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeyResponse"/></returns>
        public EnableWhiteBoxKeyResponse EnableWhiteBoxKeySync(EnableWhiteBoxKeyRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableWhiteBoxKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public async Task<EnableWhiteBoxKeysResponse> EnableWhiteBoxKeys(EnableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启用白盒密钥
        /// </summary>
        /// <param name="req"><see cref="EnableWhiteBoxKeysRequest"/></param>
        /// <returns><see cref="EnableWhiteBoxKeysResponse"/></returns>
        public EnableWhiteBoxKeysResponse EnableWhiteBoxKeysSync(EnableWhiteBoxKeysRequest req)
        {
             JsonResponseModel<EnableWhiteBoxKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableWhiteBoxKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWhiteBoxKeysResponse>>(strResp);
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
        /// 本接口用于加密最多为4KB任意数据，可用于加密数据库密码，RSA Key，或其它较小的敏感信息。对于应用的数据加密，使用GenerateDataKey生成的DataKey进行本地数据的加解密操作
        /// </summary>
        /// <param name="req"><see cref="EncryptRequest"/></param>
        /// <returns><see cref="EncryptResponse"/></returns>
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
        /// 使用白盒密钥进行加密
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public async Task<EncryptByWhiteBoxResponse> EncryptByWhiteBox(EncryptByWhiteBoxRequest req)
        {
             JsonResponseModel<EncryptByWhiteBoxResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EncryptByWhiteBox");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptByWhiteBoxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用白盒密钥进行加密
        /// </summary>
        /// <param name="req"><see cref="EncryptByWhiteBoxRequest"/></param>
        /// <returns><see cref="EncryptByWhiteBoxResponse"/></returns>
        public EncryptByWhiteBoxResponse EncryptByWhiteBoxSync(EncryptByWhiteBoxRequest req)
        {
             JsonResponseModel<EncryptByWhiteBoxResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EncryptByWhiteBox");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptByWhiteBoxResponse>>(strResp);
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
        /// 本接口生成一个数据密钥，您可以用这个密钥进行本地数据的加密。
        /// </summary>
        /// <param name="req"><see cref="GenerateDataKeyRequest"/></param>
        /// <returns><see cref="GenerateDataKeyResponse"/></returns>
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
        /// 随机数生成接口。
        /// </summary>
        /// <param name="req"><see cref="GenerateRandomRequest"/></param>
        /// <returns><see cref="GenerateRandomResponse"/></returns>
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
        /// 查询指定的CMK是否开启了密钥轮换功能。
        /// </summary>
        /// <param name="req"><see cref="GetKeyRotationStatusRequest"/></param>
        /// <returns><see cref="GetKeyRotationStatusResponse"/></returns>
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
        /// 获取导入主密钥（CMK）材料的参数，返回的Token作为执行ImportKeyMaterial的参数之一，返回的PublicKey用于对自主导入密钥材料进行加密。返回的Token和PublicKey 24小时后失效，失效后如需重新导入，需要再次调用该接口获取新的Token和PublicKey。
        /// </summary>
        /// <param name="req"><see cref="GetParametersForImportRequest"/></param>
        /// <returns><see cref="GetParametersForImportResponse"/></returns>
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
        /// 该接口用户获取 KeyUsage为ASYMMETRIC_DECRYPT_RSA_2048 和 ASYMMETRIC_DECRYPT_SM2 的非对称密钥的公钥信息，使用该公钥用户可在本地进行数据加密，使用该公钥加密的数据只能通过KMS使用对应的私钥进行解密。只有处于Enabled状态的非对称密钥才可能获取公钥。
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public async Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户获取 KeyUsage为ASYMMETRIC_DECRYPT_RSA_2048 和 ASYMMETRIC_DECRYPT_SM2 的非对称密钥的公钥信息，使用该公钥用户可在本地进行数据加密，使用该公钥加密的数据只能通过KMS使用对应的私钥进行解密。只有处于Enabled状态的非对称密钥才可能获取公钥。
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public async Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
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
        /// 用于查询该用户是否已开通KMS服务
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
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
        /// 用于导入密钥材料。只有类型为EXTERNAL 的CMK 才可以导入，导入的密钥材料使用 GetParametersForImport 获取的密钥进行加密。可以为指定的 CMK 重新导入密钥材料，并重新指定过期时间，但必须导入相同的密钥材料。CMK 密钥材料导入后不可以更换密钥材料。导入的密钥材料过期或者被删除后，指定的CMK将无法使用，需要再次导入相同的密钥材料才能正常使用。CMK是独立的，同样的密钥材料可导入不同的 CMK 中，但使用其中一个 CMK 加密的数据无法使用另一个 CMK解密。
        /// 只有Enabled 和 PendingImport状态的CMK可以导入密钥材料。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyMaterialRequest"/></param>
        /// <returns><see cref="ImportKeyMaterialResponse"/></returns>
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
        /// 列出当前Region支持的加密方式
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public async Task<ListAlgorithmsResponse> ListAlgorithms(ListAlgorithmsRequest req)
        {
             JsonResponseModel<ListAlgorithmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAlgorithms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAlgorithmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出当前Region支持的加密方式
        /// </summary>
        /// <param name="req"><see cref="ListAlgorithmsRequest"/></param>
        /// <returns><see cref="ListAlgorithmsResponse"/></returns>
        public ListAlgorithmsResponse ListAlgorithmsSync(ListAlgorithmsRequest req)
        {
             JsonResponseModel<ListAlgorithmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAlgorithms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAlgorithmsResponse>>(strResp);
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
        /// 根据指定Offset和Limit获取主密钥列表详情。
        /// </summary>
        /// <param name="req"><see cref="ListKeyDetailRequest"/></param>
        /// <returns><see cref="ListKeyDetailResponse"/></returns>
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
        /// 列出账号下面状态为Enabled， Disabled 和 PendingImport 的CMK KeyId 列表
        /// </summary>
        /// <param name="req"><see cref="ListKeysRequest"/></param>
        /// <returns><see cref="ListKeysResponse"/></returns>
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
        /// 覆盖指定密钥的设备指纹信息
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public async Task<OverwriteWhiteBoxDeviceFingerprintsResponse> OverwriteWhiteBoxDeviceFingerprints(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OverwriteWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 覆盖指定密钥的设备指纹信息
        /// </summary>
        /// <param name="req"><see cref="OverwriteWhiteBoxDeviceFingerprintsRequest"/></param>
        /// <returns><see cref="OverwriteWhiteBoxDeviceFingerprintsResponse"/></returns>
        public OverwriteWhiteBoxDeviceFingerprintsResponse OverwriteWhiteBoxDeviceFingerprintsSync(OverwriteWhiteBoxDeviceFingerprintsRequest req)
        {
             JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OverwriteWhiteBoxDeviceFingerprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OverwriteWhiteBoxDeviceFingerprintsResponse>>(strResp);
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
        /// 使用指定CMK对密文重新加密。
        /// </summary>
        /// <param name="req"><see cref="ReEncryptRequest"/></param>
        /// <returns><see cref="ReEncryptResponse"/></returns>
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
        /// CMK计划删除接口，用于指定CMK删除的时间，可选时间区间为[7,30]天
        /// </summary>
        /// <param name="req"><see cref="ScheduleKeyDeletionRequest"/></param>
        /// <returns><see cref="ScheduleKeyDeletionResponse"/></returns>
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
        /// 删除指定（key, 资源，云产品）的记录，以表明：指定的云产品的资源已不再使用当前的key。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public async Task<UnbindCloudResourceResponse> UnbindCloudResource(UnbindCloudResourceRequest req)
        {
             JsonResponseModel<UnbindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCloudResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定（key, 资源，云产品）的记录，以表明：指定的云产品的资源已不再使用当前的key。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudResourceRequest"/></param>
        /// <returns><see cref="UnbindCloudResourceResponse"/></returns>
        public UnbindCloudResourceResponse UnbindCloudResourceSync(UnbindCloudResourceRequest req)
        {
             JsonResponseModel<UnbindCloudResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindCloudResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCloudResourceResponse>>(strResp);
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
        /// 用于修改CMK的别名。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
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
        /// 该接口用于对指定的cmk修改描述信息。对于处于PendingDelete状态的CMK禁止修改。
        /// </summary>
        /// <param name="req"><see cref="UpdateKeyDescriptionRequest"/></param>
        /// <returns><see cref="UpdateKeyDescriptionResponse"/></returns>
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
