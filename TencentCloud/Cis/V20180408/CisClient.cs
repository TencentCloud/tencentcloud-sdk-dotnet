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

namespace TencentCloud.Cis.V20180408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cis.V20180408.Models;

   public class CisClient : AbstractClient{

       private const string endpoint = "cis.tencentcloudapi.com";
       private const string version = "2018-04-08";
       private const string sdkVersion = "SDK_NET_3.0.1011";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口（CreateContainerInstance）用于创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateContainerInstanceRequest"/></param>
        /// <returns><see cref="CreateContainerInstanceResponse"/></returns>
        public Task<CreateContainerInstanceResponse> CreateContainerInstance(CreateContainerInstanceRequest req)
        {
            return InternalRequestAsync<CreateContainerInstanceResponse>(req, "CreateContainerInstance");
        }

        /// <summary>
        /// 此接口（CreateContainerInstance）用于创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateContainerInstanceRequest"/></param>
        /// <returns><see cref="CreateContainerInstanceResponse"/></returns>
        public CreateContainerInstanceResponse CreateContainerInstanceSync(CreateContainerInstanceRequest req)
        {
            return InternalRequestAsync<CreateContainerInstanceResponse>(req, "CreateContainerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DeleteContainerInstance）用于删除容器实例
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerInstanceRequest"/></param>
        /// <returns><see cref="DeleteContainerInstanceResponse"/></returns>
        public Task<DeleteContainerInstanceResponse> DeleteContainerInstance(DeleteContainerInstanceRequest req)
        {
            return InternalRequestAsync<DeleteContainerInstanceResponse>(req, "DeleteContainerInstance");
        }

        /// <summary>
        /// 此接口（DeleteContainerInstance）用于删除容器实例
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerInstanceRequest"/></param>
        /// <returns><see cref="DeleteContainerInstanceResponse"/></returns>
        public DeleteContainerInstanceResponse DeleteContainerInstanceSync(DeleteContainerInstanceRequest req)
        {
            return InternalRequestAsync<DeleteContainerInstanceResponse>(req, "DeleteContainerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeContainerInstance）用于获取容器实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceResponse"/></returns>
        public Task<DescribeContainerInstanceResponse> DescribeContainerInstance(DescribeContainerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstanceResponse>(req, "DescribeContainerInstance");
        }

        /// <summary>
        /// 此接口（DescribeContainerInstance）用于获取容器实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceResponse"/></returns>
        public DescribeContainerInstanceResponse DescribeContainerInstanceSync(DescribeContainerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstanceResponse>(req, "DescribeContainerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeContainerInstanceEvents）用于查询容器实例事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceEventsResponse"/></returns>
        public Task<DescribeContainerInstanceEventsResponse> DescribeContainerInstanceEvents(DescribeContainerInstanceEventsRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstanceEventsResponse>(req, "DescribeContainerInstanceEvents");
        }

        /// <summary>
        /// 此接口（DescribeContainerInstanceEvents）用于查询容器实例事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceEventsResponse"/></returns>
        public DescribeContainerInstanceEventsResponse DescribeContainerInstanceEventsSync(DescribeContainerInstanceEventsRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstanceEventsResponse>(req, "DescribeContainerInstanceEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeContainerInstances）查询容器实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeContainerInstancesResponse"/></returns>
        public Task<DescribeContainerInstancesResponse> DescribeContainerInstances(DescribeContainerInstancesRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstancesResponse>(req, "DescribeContainerInstances");
        }

        /// <summary>
        /// 此接口（DescribeContainerInstances）查询容器实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeContainerInstancesResponse"/></returns>
        public DescribeContainerInstancesResponse DescribeContainerInstancesSync(DescribeContainerInstancesRequest req)
        {
            return InternalRequestAsync<DescribeContainerInstancesResponse>(req, "DescribeContainerInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeContainerLog）用于获取容器日志信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerLogRequest"/></param>
        /// <returns><see cref="DescribeContainerLogResponse"/></returns>
        public Task<DescribeContainerLogResponse> DescribeContainerLog(DescribeContainerLogRequest req)
        {
            return InternalRequestAsync<DescribeContainerLogResponse>(req, "DescribeContainerLog");
        }

        /// <summary>
        /// 此接口（DescribeContainerLog）用于获取容器日志信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerLogRequest"/></param>
        /// <returns><see cref="DescribeContainerLogResponse"/></returns>
        public DescribeContainerLogResponse DescribeContainerLogSync(DescribeContainerLogRequest req)
        {
            return InternalRequestAsync<DescribeContainerLogResponse>(req, "DescribeContainerLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（InquiryPriceCreateCis）用于查询容器实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateCisRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateCisResponse"/></returns>
        public Task<InquiryPriceCreateCisResponse> InquiryPriceCreateCis(InquiryPriceCreateCisRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateCisResponse>(req, "InquiryPriceCreateCis");
        }

        /// <summary>
        /// 此接口（InquiryPriceCreateCis）用于查询容器实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateCisRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateCisResponse"/></returns>
        public InquiryPriceCreateCisResponse InquiryPriceCreateCisSync(InquiryPriceCreateCisRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateCisResponse>(req, "InquiryPriceCreateCis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
