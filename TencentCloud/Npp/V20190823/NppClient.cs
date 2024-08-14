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

namespace TencentCloud.Npp.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Npp.V20190823.Models;

   public class NppClient : AbstractClient{

       private const string endpoint = "npp.tencentcloudapi.com";
       private const string version = "2019-08-23";
       private const string sdkVersion = "SDK_NET_3.0.1068";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public NppClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public NppClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 回拨呼叫请求
        /// </summary>
        /// <param name="req"><see cref="CreateCallBackRequest"/></param>
        /// <returns><see cref="CreateCallBackResponse"/></returns>
        public Task<CreateCallBackResponse> CreateCallBack(CreateCallBackRequest req)
        {
            return InternalRequestAsync<CreateCallBackResponse>(req, "CreateCallBack");
        }

        /// <summary>
        /// 回拨呼叫请求
        /// </summary>
        /// <param name="req"><see cref="CreateCallBackRequest"/></param>
        /// <returns><see cref="CreateCallBackResponse"/></returns>
        public CreateCallBackResponse CreateCallBackSync(CreateCallBackRequest req)
        {
            return InternalRequestAsync<CreateCallBackResponse>(req, "CreateCallBack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直拨解绑中间号
        /// </summary>
        /// <param name="req"><see cref="DelVirtualNumRequest"/></param>
        /// <returns><see cref="DelVirtualNumResponse"/></returns>
        public Task<DelVirtualNumResponse> DelVirtualNum(DelVirtualNumRequest req)
        {
            return InternalRequestAsync<DelVirtualNumResponse>(req, "DelVirtualNum");
        }

        /// <summary>
        /// 直拨解绑中间号
        /// </summary>
        /// <param name="req"><see cref="DelVirtualNumRequest"/></param>
        /// <returns><see cref="DelVirtualNumResponse"/></returns>
        public DelVirtualNumResponse DelVirtualNumSync(DelVirtualNumRequest req)
        {
            return InternalRequestAsync<DelVirtualNumResponse>(req, "DelVirtualNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回拨呼叫取消
        /// </summary>
        /// <param name="req"><see cref="DeleteCallBackRequest"/></param>
        /// <returns><see cref="DeleteCallBackResponse"/></returns>
        public Task<DeleteCallBackResponse> DeleteCallBack(DeleteCallBackRequest req)
        {
            return InternalRequestAsync<DeleteCallBackResponse>(req, "DeleteCallBack");
        }

        /// <summary>
        /// 回拨呼叫取消
        /// </summary>
        /// <param name="req"><see cref="DeleteCallBackRequest"/></param>
        /// <returns><see cref="DeleteCallBackResponse"/></returns>
        public DeleteCallBackResponse DeleteCallBackSync(DeleteCallBackRequest req)
        {
            return InternalRequestAsync<DeleteCallBackResponse>(req, "DeleteCallBack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackCdrRequest"/></param>
        /// <returns><see cref="DescribeCallBackCdrResponse"/></returns>
        public Task<DescribeCallBackCdrResponse> DescribeCallBackCdr(DescribeCallBackCdrRequest req)
        {
            return InternalRequestAsync<DescribeCallBackCdrResponse>(req, "DescribeCallBackCdr");
        }

        /// <summary>
        /// 回拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackCdrRequest"/></param>
        /// <returns><see cref="DescribeCallBackCdrResponse"/></returns>
        public DescribeCallBackCdrResponse DescribeCallBackCdrSync(DescribeCallBackCdrRequest req)
        {
            return InternalRequestAsync<DescribeCallBackCdrResponse>(req, "DescribeCallBackCdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回拨通话状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackStatusRequest"/></param>
        /// <returns><see cref="DescribeCallBackStatusResponse"/></returns>
        public Task<DescribeCallBackStatusResponse> DescribeCallBackStatus(DescribeCallBackStatusRequest req)
        {
            return InternalRequestAsync<DescribeCallBackStatusResponse>(req, "DescribeCallBackStatus");
        }

        /// <summary>
        /// 回拨通话状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackStatusRequest"/></param>
        /// <returns><see cref="DescribeCallBackStatusResponse"/></returns>
        public DescribeCallBackStatusResponse DescribeCallBackStatusSync(DescribeCallBackStatusRequest req)
        {
            return InternalRequestAsync<DescribeCallBackStatusResponse>(req, "DescribeCallBackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回拨拉取主叫显号号码集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCallerDisplayListRequest"/></param>
        /// <returns><see cref="DescribeCallerDisplayListResponse"/></returns>
        public Task<DescribeCallerDisplayListResponse> DescribeCallerDisplayList(DescribeCallerDisplayListRequest req)
        {
            return InternalRequestAsync<DescribeCallerDisplayListResponse>(req, "DescribeCallerDisplayList");
        }

        /// <summary>
        /// 回拨拉取主叫显号号码集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCallerDisplayListRequest"/></param>
        /// <returns><see cref="DescribeCallerDisplayListResponse"/></returns>
        public DescribeCallerDisplayListResponse DescribeCallerDisplayListSync(DescribeCallerDisplayListRequest req)
        {
            return InternalRequestAsync<DescribeCallerDisplayListResponse>(req, "DescribeCallerDisplayList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="Get400CdrRequest"/></param>
        /// <returns><see cref="Get400CdrResponse"/></returns>
        public Task<Get400CdrResponse> Get400Cdr(Get400CdrRequest req)
        {
            return InternalRequestAsync<Get400CdrResponse>(req, "Get400Cdr");
        }

        /// <summary>
        /// 直拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="Get400CdrRequest"/></param>
        /// <returns><see cref="Get400CdrResponse"/></returns>
        public Get400CdrResponse Get400CdrSync(Get400CdrRequest req)
        {
            return InternalRequestAsync<Get400CdrResponse>(req, "Get400Cdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直拨获取中间号（App 使用方发起）
        /// </summary>
        /// <param name="req"><see cref="GetVirtualNumRequest"/></param>
        /// <returns><see cref="GetVirtualNumResponse"/></returns>
        public Task<GetVirtualNumResponse> GetVirtualNum(GetVirtualNumRequest req)
        {
            return InternalRequestAsync<GetVirtualNumResponse>(req, "GetVirtualNum");
        }

        /// <summary>
        /// 直拨获取中间号（App 使用方发起）
        /// </summary>
        /// <param name="req"><see cref="GetVirtualNumRequest"/></param>
        /// <returns><see cref="GetVirtualNumResponse"/></returns>
        public GetVirtualNumResponse GetVirtualNumSync(GetVirtualNumRequest req)
        {
            return InternalRequestAsync<GetVirtualNumResponse>(req, "GetVirtualNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
