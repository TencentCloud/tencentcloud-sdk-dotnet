/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ig.V20210518
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ig.V20210518.Models;

   public class IgClient : AbstractClient{

       private const string endpoint = "ig.tencentcloudapi.com";
       private const string version = "2021-05-18";
       private const string sdkVersion = "SDK_NET_3.0.1435";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询智能导诊订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIgOrderListRequest"/></param>
        /// <returns><see cref="DescribeIgOrderListResponse"/></returns>
        public Task<DescribeIgOrderListResponse> DescribeIgOrderList(DescribeIgOrderListRequest req)
        {
            return InternalRequestAsync<DescribeIgOrderListResponse>(req, "DescribeIgOrderList");
        }

        /// <summary>
        /// 查询智能导诊订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIgOrderListRequest"/></param>
        /// <returns><see cref="DescribeIgOrderListResponse"/></returns>
        public DescribeIgOrderListResponse DescribeIgOrderListSync(DescribeIgOrderListRequest req)
        {
            return InternalRequestAsync<DescribeIgOrderListResponse>(req, "DescribeIgOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 大模型问药拍药盒
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisDrugRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisDrugResponse"/></returns>
        public Task<GetLLMDiagnosisDrugResponse> GetLLMDiagnosisDrug(GetLLMDiagnosisDrugRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisDrugResponse>(req, "GetLLMDiagnosisDrug");
        }

        /// <summary>
        /// 大模型问药拍药盒
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisDrugRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisDrugResponse"/></returns>
        public GetLLMDiagnosisDrugResponse GetLLMDiagnosisDrugSync(GetLLMDiagnosisDrugRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisDrugResponse>(req, "GetLLMDiagnosisDrug")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 大模型问药问答
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisDrugChatRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisDrugChatResponse"/></returns>
        public Task<GetLLMDiagnosisDrugChatResponse> GetLLMDiagnosisDrugChat(GetLLMDiagnosisDrugChatRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisDrugChatResponse>(req, "GetLLMDiagnosisDrugChat");
        }

        /// <summary>
        /// 大模型问药问答
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisDrugChatRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisDrugChatResponse"/></returns>
        public GetLLMDiagnosisDrugChatResponse GetLLMDiagnosisDrugChatSync(GetLLMDiagnosisDrugChatRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisDrugChatResponse>(req, "GetLLMDiagnosisDrugChat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 大模型健康自诊
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisHealthRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisHealthResponse"/></returns>
        public Task<GetLLMDiagnosisHealthResponse> GetLLMDiagnosisHealth(GetLLMDiagnosisHealthRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisHealthResponse>(req, "GetLLMDiagnosisHealth");
        }

        /// <summary>
        /// 大模型健康自诊
        /// </summary>
        /// <param name="req"><see cref="GetLLMDiagnosisHealthRequest"/></param>
        /// <returns><see cref="GetLLMDiagnosisHealthResponse"/></returns>
        public GetLLMDiagnosisHealthResponse GetLLMDiagnosisHealthSync(GetLLMDiagnosisHealthRequest req)
        {
            return InternalRequestAsync<GetLLMDiagnosisHealthResponse>(req, "GetLLMDiagnosisHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 大模型报告解读
        /// </summary>
        /// <param name="req"><see cref="GetLLMReportInterpretationRequest"/></param>
        /// <returns><see cref="GetLLMReportInterpretationResponse"/></returns>
        public Task<GetLLMReportInterpretationResponse> GetLLMReportInterpretation(GetLLMReportInterpretationRequest req)
        {
            return InternalRequestAsync<GetLLMReportInterpretationResponse>(req, "GetLLMReportInterpretation");
        }

        /// <summary>
        /// 大模型报告解读
        /// </summary>
        /// <param name="req"><see cref="GetLLMReportInterpretationRequest"/></param>
        /// <returns><see cref="GetLLMReportInterpretationResponse"/></returns>
        public GetLLMReportInterpretationResponse GetLLMReportInterpretationSync(GetLLMReportInterpretationRequest req)
        {
            return InternalRequestAsync<GetLLMReportInterpretationResponse>(req, "GetLLMReportInterpretation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询药品说明书
        /// </summary>
        /// <param name="req"><see cref="QueryDrugInstructionsRequest"/></param>
        /// <returns><see cref="QueryDrugInstructionsResponse"/></returns>
        public Task<QueryDrugInstructionsResponse> QueryDrugInstructions(QueryDrugInstructionsRequest req)
        {
            return InternalRequestAsync<QueryDrugInstructionsResponse>(req, "QueryDrugInstructions");
        }

        /// <summary>
        /// 查询药品说明书
        /// </summary>
        /// <param name="req"><see cref="QueryDrugInstructionsRequest"/></param>
        /// <returns><see cref="QueryDrugInstructionsResponse"/></returns>
        public QueryDrugInstructionsResponse QueryDrugInstructionsSync(QueryDrugInstructionsRequest req)
        {
            return InternalRequestAsync<QueryDrugInstructionsResponse>(req, "QueryDrugInstructions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
