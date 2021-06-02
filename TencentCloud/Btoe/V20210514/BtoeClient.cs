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

namespace TencentCloud.Btoe.V20210514
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Btoe.V20210514.Models;

   public class BtoeClient : AbstractClient{

       private const string endpoint = "btoe.tencentcloudapi.com";
       private const string version = "2021-05-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BtoeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BtoeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的音频原文件或下载URL，BTOE对音频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。音频类型支持格式：mp3、wav、wma、midi、flac；原文件上传大小不超过5 MB，下载URL文件大小不超过25 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioDepositRequest"/></param>
        /// <returns><see cref="CreateAudioDepositResponse"/></returns>
        public async Task<CreateAudioDepositResponse> CreateAudioDeposit(CreateAudioDepositRequest req)
        {
             JsonResponseModel<CreateAudioDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudioDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的音频原文件或下载URL，BTOE对音频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。音频类型支持格式：mp3、wav、wma、midi、flac；原文件上传大小不超过5 MB，下载URL文件大小不超过25 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioDepositRequest"/></param>
        /// <returns><see cref="CreateAudioDepositResponse"/></returns>
        public CreateAudioDepositResponse CreateAudioDepositSync(CreateAudioDepositRequest req)
        {
             JsonResponseModel<CreateAudioDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudioDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的业务数据明文，业务数据明文存证写入后不可修改，BTOE对业务数据明文存证生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateDataDepositRequest"/></param>
        /// <returns><see cref="CreateDataDepositResponse"/></returns>
        public async Task<CreateDataDepositResponse> CreateDataDeposit(CreateDataDepositRequest req)
        {
             JsonResponseModel<CreateDataDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的业务数据明文，业务数据明文存证写入后不可修改，BTOE对业务数据明文存证生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateDataDepositRequest"/></param>
        /// <returns><see cref="CreateDataDepositResponse"/></returns>
        public CreateDataDepositResponse CreateDataDepositSync(CreateDataDepositRequest req)
        {
             JsonResponseModel<CreateDataDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的文档原文件或下载URL，BTOE对文档原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。文档类型支持格式：doc、docx、xls、xlsx、ppt、pptx、 pdf、html、txt、md、csv；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateDocDepositRequest"/></param>
        /// <returns><see cref="CreateDocDepositResponse"/></returns>
        public async Task<CreateDocDepositResponse> CreateDocDeposit(CreateDocDepositRequest req)
        {
             JsonResponseModel<CreateDocDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDocDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的文档原文件或下载URL，BTOE对文档原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。文档类型支持格式：doc、docx、xls、xlsx、ppt、pptx、 pdf、html、txt、md、csv；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateDocDepositRequest"/></param>
        /// <returns><see cref="CreateDocDepositResponse"/></returns>
        public CreateDocDepositResponse CreateDocDepositSync(CreateDocDepositRequest req)
        {
             JsonResponseModel<CreateDocDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDocDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositRequest"/></param>
        /// <returns><see cref="CreateHashDepositResponse"/></returns>
        public async Task<CreateHashDepositResponse> CreateHashDeposit(CreateHashDepositRequest req)
        {
             JsonResponseModel<CreateHashDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHashDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositRequest"/></param>
        /// <returns><see cref="CreateHashDepositResponse"/></returns>
        public CreateHashDepositResponse CreateHashDepositSync(CreateHashDepositRequest req)
        {
             JsonResponseModel<CreateHashDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHashDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，本接口不生成区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoCertRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoCertResponse"/></returns>
        public async Task<CreateHashDepositNoCertResponse> CreateHashDepositNoCert(CreateHashDepositNoCertRequest req)
        {
             JsonResponseModel<CreateHashDepositNoCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHashDepositNoCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositNoCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，本接口不生成区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoCertRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoCertResponse"/></returns>
        public CreateHashDepositNoCertResponse CreateHashDepositNoCertSync(CreateHashDepositNoCertRequest req)
        {
             JsonResponseModel<CreateHashDepositNoCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHashDepositNoCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositNoCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成无电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoSealRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoSealResponse"/></returns>
        public async Task<CreateHashDepositNoSealResponse> CreateHashDepositNoSeal(CreateHashDepositNoSealRequest req)
        {
             JsonResponseModel<CreateHashDepositNoSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHashDepositNoSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositNoSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成无电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoSealRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoSealResponse"/></returns>
        public CreateHashDepositNoSealResponse CreateHashDepositNoSealSync(CreateHashDepositNoSealRequest req)
        {
             JsonResponseModel<CreateHashDepositNoSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHashDepositNoSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHashDepositNoSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的图片原文件或下载URL，BTOE对图片原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。图片类型支持格式：png、jpg、jpeg、bmp、gif、svg；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateImageDepositRequest"/></param>
        /// <returns><see cref="CreateImageDepositResponse"/></returns>
        public async Task<CreateImageDepositResponse> CreateImageDeposit(CreateImageDepositRequest req)
        {
             JsonResponseModel<CreateImageDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的图片原文件或下载URL，BTOE对图片原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。图片类型支持格式：png、jpg、jpeg、bmp、gif、svg；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateImageDepositRequest"/></param>
        /// <returns><see cref="CreateImageDepositResponse"/></returns>
        public CreateImageDepositResponse CreateImageDepositSync(CreateImageDepositRequest req)
        {
             JsonResponseModel<CreateImageDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的视频的原文件或下载URL，BTOE对视频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。视频文件支持格式：mp4、avi、mkv、mov、flv,wmv,rmvb,3gp；文件大小限制：直接上传原文件不大于5MB，下载URL文件大小不大于200 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDepositRequest"/></param>
        /// <returns><see cref="CreateVideoDepositResponse"/></returns>
        public async Task<CreateVideoDepositResponse> CreateVideoDeposit(CreateVideoDepositRequest req)
        {
             JsonResponseModel<CreateVideoDepositResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的视频的原文件或下载URL，BTOE对视频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。视频文件支持格式：mp4、avi、mkv、mov、flv,wmv,rmvb,3gp；文件大小限制：直接上传原文件不大于5MB，下载URL文件大小不大于200 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDepositRequest"/></param>
        /// <returns><see cref="CreateVideoDepositResponse"/></returns>
        public CreateVideoDepositResponse CreateVideoDepositSync(CreateVideoDepositRequest req)
        {
             JsonResponseModel<CreateVideoDepositResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoDeposit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoDepositResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证电子凭证信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositCertRequest"/></param>
        /// <returns><see cref="GetDepositCertResponse"/></returns>
        public async Task<GetDepositCertResponse> GetDepositCert(GetDepositCertRequest req)
        {
             JsonResponseModel<GetDepositCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDepositCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证电子凭证信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositCertRequest"/></param>
        /// <returns><see cref="GetDepositCertResponse"/></returns>
        public GetDepositCertResponse GetDepositCertSync(GetDepositCertRequest req)
        {
             JsonResponseModel<GetDepositCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDepositCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE获取存证文件的下载URL。
        /// -注：Hash类存证、业务数据明文存证不产生存证文件。
        /// </summary>
        /// <param name="req"><see cref="GetDepositFileRequest"/></param>
        /// <returns><see cref="GetDepositFileResponse"/></returns>
        public async Task<GetDepositFileResponse> GetDepositFile(GetDepositFileRequest req)
        {
             JsonResponseModel<GetDepositFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDepositFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE获取存证文件的下载URL。
        /// -注：Hash类存证、业务数据明文存证不产生存证文件。
        /// </summary>
        /// <param name="req"><see cref="GetDepositFileRequest"/></param>
        /// <returns><see cref="GetDepositFileResponse"/></returns>
        public GetDepositFileResponse GetDepositFileSync(GetDepositFileRequest req)
        {
             JsonResponseModel<GetDepositFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDepositFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证基本信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositInfoRequest"/></param>
        /// <returns><see cref="GetDepositInfoResponse"/></returns>
        public async Task<GetDepositInfoResponse> GetDepositInfo(GetDepositInfoRequest req)
        {
             JsonResponseModel<GetDepositInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDepositInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证基本信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositInfoRequest"/></param>
        /// <returns><see cref="GetDepositInfoResponse"/></returns>
        public GetDepositInfoResponse GetDepositInfoSync(GetDepositInfoRequest req)
        {
             JsonResponseModel<GetDepositInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDepositInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDepositInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户向BTOE核验存证结果中的区块链交易hash
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceBlockChainTxHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceBlockChainTxHashResponse"/></returns>
        public async Task<VerifyEvidenceBlockChainTxHashResponse> VerifyEvidenceBlockChainTxHash(VerifyEvidenceBlockChainTxHashRequest req)
        {
             JsonResponseModel<VerifyEvidenceBlockChainTxHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyEvidenceBlockChainTxHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEvidenceBlockChainTxHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户向BTOE核验存证结果中的区块链交易hash
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceBlockChainTxHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceBlockChainTxHashResponse"/></returns>
        public VerifyEvidenceBlockChainTxHashResponse VerifyEvidenceBlockChainTxHashSync(VerifyEvidenceBlockChainTxHashRequest req)
        {
             JsonResponseModel<VerifyEvidenceBlockChainTxHashResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyEvidenceBlockChainTxHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEvidenceBlockChainTxHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户存证内容hash向BTOE核验存证记录的真实性。
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceHashResponse"/></returns>
        public async Task<VerifyEvidenceHashResponse> VerifyEvidenceHash(VerifyEvidenceHashRequest req)
        {
             JsonResponseModel<VerifyEvidenceHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyEvidenceHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEvidenceHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户存证内容hash向BTOE核验存证记录的真实性。
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceHashResponse"/></returns>
        public VerifyEvidenceHashResponse VerifyEvidenceHashSync(VerifyEvidenceHashRequest req)
        {
             JsonResponseModel<VerifyEvidenceHashResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyEvidenceHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEvidenceHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
