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
       private const string sdkVersion = "SDK_NET_3.0.1189";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BtoeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的音频原文件或下载URL，BTOE对音频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。音频类型支持格式：mp3、wav、wma、midi、flac；原文件上传大小不超过5 MB，下载URL文件大小不超过25 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioDepositRequest"/></param>
        /// <returns><see cref="CreateAudioDepositResponse"/></returns>
        public Task<CreateAudioDepositResponse> CreateAudioDeposit(CreateAudioDepositRequest req)
        {
            return InternalRequestAsync<CreateAudioDepositResponse>(req, "CreateAudioDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的音频原文件或下载URL，BTOE对音频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。音频类型支持格式：mp3、wav、wma、midi、flac；原文件上传大小不超过5 MB，下载URL文件大小不超过25 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioDepositRequest"/></param>
        /// <returns><see cref="CreateAudioDepositResponse"/></returns>
        public CreateAudioDepositResponse CreateAudioDepositSync(CreateAudioDepositRequest req)
        {
            return InternalRequestAsync<CreateAudioDepositResponse>(req, "CreateAudioDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的业务数据明文，业务数据明文存证写入后不可修改，BTOE对业务数据明文存证生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateDataDepositRequest"/></param>
        /// <returns><see cref="CreateDataDepositResponse"/></returns>
        public Task<CreateDataDepositResponse> CreateDataDeposit(CreateDataDepositRequest req)
        {
            return InternalRequestAsync<CreateDataDepositResponse>(req, "CreateDataDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的业务数据明文，业务数据明文存证写入后不可修改，BTOE对业务数据明文存证生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateDataDepositRequest"/></param>
        /// <returns><see cref="CreateDataDepositResponse"/></returns>
        public CreateDataDepositResponse CreateDataDepositSync(CreateDataDepositRequest req)
        {
            return InternalRequestAsync<CreateDataDepositResponse>(req, "CreateDataDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的文档原文件或下载URL，BTOE对文档原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。文档类型支持格式：doc、docx、xls、xlsx、ppt、pptx、 pdf、html、txt、md、csv；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateDocDepositRequest"/></param>
        /// <returns><see cref="CreateDocDepositResponse"/></returns>
        public Task<CreateDocDepositResponse> CreateDocDeposit(CreateDocDepositRequest req)
        {
            return InternalRequestAsync<CreateDocDepositResponse>(req, "CreateDocDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的文档原文件或下载URL，BTOE对文档原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。文档类型支持格式：doc、docx、xls、xlsx、ppt、pptx、 pdf、html、txt、md、csv；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateDocDepositRequest"/></param>
        /// <returns><see cref="CreateDocDepositResponse"/></returns>
        public CreateDocDepositResponse CreateDocDepositSync(CreateDocDepositRequest req)
        {
            return InternalRequestAsync<CreateDocDepositResponse>(req, "CreateDocDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositRequest"/></param>
        /// <returns><see cref="CreateHashDepositResponse"/></returns>
        public Task<CreateHashDepositResponse> CreateHashDeposit(CreateHashDepositRequest req)
        {
            return InternalRequestAsync<CreateHashDepositResponse>(req, "CreateHashDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositRequest"/></param>
        /// <returns><see cref="CreateHashDepositResponse"/></returns>
        public CreateHashDepositResponse CreateHashDepositSync(CreateHashDepositRequest req)
        {
            return InternalRequestAsync<CreateHashDepositResponse>(req, "CreateHashDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，本接口不生成区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoCertRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoCertResponse"/></returns>
        public Task<CreateHashDepositNoCertResponse> CreateHashDepositNoCert(CreateHashDepositNoCertRequest req)
        {
            return InternalRequestAsync<CreateHashDepositNoCertResponse>(req, "CreateHashDepositNoCert");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，本接口不生成区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoCertRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoCertResponse"/></returns>
        public CreateHashDepositNoCertResponse CreateHashDepositNoCertSync(CreateHashDepositNoCertRequest req)
        {
            return InternalRequestAsync<CreateHashDepositNoCertResponse>(req, "CreateHashDepositNoCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成无电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoSealRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoSealResponse"/></returns>
        public Task<CreateHashDepositNoSealResponse> CreateHashDepositNoSeal(CreateHashDepositNoSealRequest req)
        {
            return InternalRequestAsync<CreateHashDepositNoSealResponse>(req, "CreateHashDepositNoSeal");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的原文数据Hash值，BTOE对业务数据Hash值存证上链，并生成无电子签章的区块链存证电子凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateHashDepositNoSealRequest"/></param>
        /// <returns><see cref="CreateHashDepositNoSealResponse"/></returns>
        public CreateHashDepositNoSealResponse CreateHashDepositNoSealSync(CreateHashDepositNoSealRequest req)
        {
            return InternalRequestAsync<CreateHashDepositNoSealResponse>(req, "CreateHashDepositNoSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的图片原文件或下载URL，BTOE对图片原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。图片类型支持格式：png、jpg、jpeg、bmp、gif、svg；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateImageDepositRequest"/></param>
        /// <returns><see cref="CreateImageDepositResponse"/></returns>
        public Task<CreateImageDepositResponse> CreateImageDeposit(CreateImageDepositRequest req)
        {
            return InternalRequestAsync<CreateImageDepositResponse>(req, "CreateImageDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的图片原文件或下载URL，BTOE对图片原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。图片类型支持格式：png、jpg、jpeg、bmp、gif、svg；原文件上传大小不超过5 MB，下载URL文件大小不超过10 MB。
        /// </summary>
        /// <param name="req"><see cref="CreateImageDepositRequest"/></param>
        /// <returns><see cref="CreateImageDepositResponse"/></returns>
        public CreateImageDepositResponse CreateImageDepositSync(CreateImageDepositRequest req)
        {
            return InternalRequestAsync<CreateImageDepositResponse>(req, "CreateImageDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的视频的原文件或下载URL，BTOE对视频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。视频文件支持格式：mp4、avi、mkv、mov、flv,wmv,rmvb,3gp；文件大小限制：直接上传原文件不大于5MB。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDepositRequest"/></param>
        /// <returns><see cref="CreateVideoDepositResponse"/></returns>
        public Task<CreateVideoDepositResponse> CreateVideoDeposit(CreateVideoDepositRequest req)
        {
            return InternalRequestAsync<CreateVideoDepositResponse>(req, "CreateVideoDeposit");
        }

        /// <summary>
        /// 用户通过本接口向BTOE写入待存证的视频的原文件或下载URL，BTOE对视频原文件存储后，将其Hash值存证上链，并生成含有电子签章的区块链存证电子凭证。视频文件支持格式：mp4、avi、mkv、mov、flv,wmv,rmvb,3gp；文件大小限制：直接上传原文件不大于5MB。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDepositRequest"/></param>
        /// <returns><see cref="CreateVideoDepositResponse"/></returns>
        public CreateVideoDepositResponse CreateVideoDepositSync(CreateVideoDepositRequest req)
        {
            return InternalRequestAsync<CreateVideoDepositResponse>(req, "CreateVideoDeposit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证电子凭证信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositCertRequest"/></param>
        /// <returns><see cref="GetDepositCertResponse"/></returns>
        public Task<GetDepositCertResponse> GetDepositCert(GetDepositCertRequest req)
        {
            return InternalRequestAsync<GetDepositCertResponse>(req, "GetDepositCert");
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证电子凭证信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositCertRequest"/></param>
        /// <returns><see cref="GetDepositCertResponse"/></returns>
        public GetDepositCertResponse GetDepositCertSync(GetDepositCertRequest req)
        {
            return InternalRequestAsync<GetDepositCertResponse>(req, "GetDepositCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过存证编码向BTOE获取存证文件的下载URL。
        /// -注：Hash类存证、业务数据明文存证不产生存证文件。
        /// </summary>
        /// <param name="req"><see cref="GetDepositFileRequest"/></param>
        /// <returns><see cref="GetDepositFileResponse"/></returns>
        public Task<GetDepositFileResponse> GetDepositFile(GetDepositFileRequest req)
        {
            return InternalRequestAsync<GetDepositFileResponse>(req, "GetDepositFile");
        }

        /// <summary>
        /// 用户通过存证编码向BTOE获取存证文件的下载URL。
        /// -注：Hash类存证、业务数据明文存证不产生存证文件。
        /// </summary>
        /// <param name="req"><see cref="GetDepositFileRequest"/></param>
        /// <returns><see cref="GetDepositFileResponse"/></returns>
        public GetDepositFileResponse GetDepositFileSync(GetDepositFileRequest req)
        {
            return InternalRequestAsync<GetDepositFileResponse>(req, "GetDepositFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证基本信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositInfoRequest"/></param>
        /// <returns><see cref="GetDepositInfoResponse"/></returns>
        public Task<GetDepositInfoResponse> GetDepositInfo(GetDepositInfoRequest req)
        {
            return InternalRequestAsync<GetDepositInfoResponse>(req, "GetDepositInfo");
        }

        /// <summary>
        /// 用户通过存证编码向BTOE查询存证基本信息。
        /// </summary>
        /// <param name="req"><see cref="GetDepositInfoRequest"/></param>
        /// <returns><see cref="GetDepositInfoResponse"/></returns>
        public GetDepositInfoResponse GetDepositInfoSync(GetDepositInfoRequest req)
        {
            return InternalRequestAsync<GetDepositInfoResponse>(req, "GetDepositInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户向BTOE核验存证结果中的区块链交易hash的真实性
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceBlockChainTxHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceBlockChainTxHashResponse"/></returns>
        public Task<VerifyEvidenceBlockChainTxHashResponse> VerifyEvidenceBlockChainTxHash(VerifyEvidenceBlockChainTxHashRequest req)
        {
            return InternalRequestAsync<VerifyEvidenceBlockChainTxHashResponse>(req, "VerifyEvidenceBlockChainTxHash");
        }

        /// <summary>
        /// 用户向BTOE核验存证结果中的区块链交易hash的真实性
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceBlockChainTxHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceBlockChainTxHashResponse"/></returns>
        public VerifyEvidenceBlockChainTxHashResponse VerifyEvidenceBlockChainTxHashSync(VerifyEvidenceBlockChainTxHashRequest req)
        {
            return InternalRequestAsync<VerifyEvidenceBlockChainTxHashResponse>(req, "VerifyEvidenceBlockChainTxHash")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户存证内容hash向BTOE核验存证记录的真实性。
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceHashResponse"/></returns>
        public Task<VerifyEvidenceHashResponse> VerifyEvidenceHash(VerifyEvidenceHashRequest req)
        {
            return InternalRequestAsync<VerifyEvidenceHashResponse>(req, "VerifyEvidenceHash");
        }

        /// <summary>
        /// 用户存证内容hash向BTOE核验存证记录的真实性。
        /// </summary>
        /// <param name="req"><see cref="VerifyEvidenceHashRequest"/></param>
        /// <returns><see cref="VerifyEvidenceHashResponse"/></returns>
        public VerifyEvidenceHashResponse VerifyEvidenceHashSync(VerifyEvidenceHashRequest req)
        {
            return InternalRequestAsync<VerifyEvidenceHashResponse>(req, "VerifyEvidenceHash")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
