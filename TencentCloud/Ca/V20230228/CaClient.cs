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

namespace TencentCloud.Ca.V20230228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ca.V20230228.Models;

   public class CaClient : AbstractClient{

       private const string endpoint = "ca.tencentcloudapi.com";
       private const string version = "2023-02-28";
       private const string sdkVersion = "SDK_NET_3.0.1203";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建签名验证报告任务，此接口为异步盖章接口，盖章时效24小时。
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyReportRequest"/></param>
        /// <returns><see cref="CreateVerifyReportResponse"/></returns>
        public Task<CreateVerifyReportResponse> CreateVerifyReport(CreateVerifyReportRequest req)
        {
            return InternalRequestAsync<CreateVerifyReportResponse>(req, "CreateVerifyReport");
        }

        /// <summary>
        /// 创建签名验证报告任务，此接口为异步盖章接口，盖章时效24小时。
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyReportRequest"/></param>
        /// <returns><see cref="CreateVerifyReportResponse"/></returns>
        public CreateVerifyReportResponse CreateVerifyReportSync(CreateVerifyReportRequest req)
        {
            return InternalRequestAsync<CreateVerifyReportResponse>(req, "CreateVerifyReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载验签报告url，url有效期默认12小时
        /// </summary>
        /// <param name="req"><see cref="DescribeVerifyReportRequest"/></param>
        /// <returns><see cref="DescribeVerifyReportResponse"/></returns>
        public Task<DescribeVerifyReportResponse> DescribeVerifyReport(DescribeVerifyReportRequest req)
        {
            return InternalRequestAsync<DescribeVerifyReportResponse>(req, "DescribeVerifyReport");
        }

        /// <summary>
        /// 下载验签报告url，url有效期默认12小时
        /// </summary>
        /// <param name="req"><see cref="DescribeVerifyReportRequest"/></param>
        /// <returns><see cref="DescribeVerifyReportResponse"/></returns>
        public DescribeVerifyReportResponse DescribeVerifyReportSync(DescribeVerifyReportRequest req)
        {
            return InternalRequestAsync<DescribeVerifyReportResponse>(req, "DescribeVerifyReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public Task<UploadFileResponse> UploadFile(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile");
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public UploadFileResponse UploadFileSync(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
