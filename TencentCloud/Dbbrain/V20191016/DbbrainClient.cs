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

namespace TencentCloud.Dbbrain.V20191016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20191016.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2019-10-16";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DbbrainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns>参考<see cref="DescribeDBDiagEventResponse"/>实例</returns>
        public async Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBDiagEvent接口的同步版本，获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns>参考<see cref="DescribeDBDiagEventResponse"/>实例</returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns>参考<see cref="DescribeDBDiagHistoryResponse"/>实例</returns>
        public async Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBDiagHistory接口的同步版本，获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns>参考<see cref="DescribeDBDiagHistoryResponse"/>实例</returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取慢日志统计柱状图
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogTimeSeriesStatsResponse"/>实例</returns>
        public async Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSlowLogTimeSeriesStats接口的同步版本，获取慢日志统计柱状图
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogTimeSeriesStatsResponse"/>实例</returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogTopSqlsResponse"/>实例</returns>
        public async Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSlowLogTopSqls接口的同步版本，按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogTopSqlsResponse"/>实例</returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
