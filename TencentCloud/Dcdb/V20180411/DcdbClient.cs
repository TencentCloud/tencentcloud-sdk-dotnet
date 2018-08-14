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

namespace TencentCloud.Dcdb.V20180411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dcdb.V20180411.Models;

   public class DcdbClient : AbstractClient{

       private const string endpoint = "dcdb.tencentcloudapi.com";
       private const string version = "2018-04-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DcdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DcdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CreateDCDBInstance）用于创建包年包月的云数据库实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateDCDBInstanceResponse"/>实例</returns>
        public async Task<CreateDCDBInstanceResponse> CreateDCDBInstance(CreateDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBLogFilesResponse"/>实例</returns>
        public async Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBInstancesResponse"/>实例</returns>
        public async Task<DescribeDCDBInstancesResponse> DescribeDCDBInstances(DescribeDCDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBPriceResponse"/>实例</returns>
        public async Task<DescribeDCDBPriceResponse> DescribeDCDBPrice(DescribeDCDBPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBRenewalPriceResponse"/>实例</returns>
        public async Task<DescribeDCDBRenewalPriceResponse> DescribeDCDBRenewalPrice(DescribeDCDBRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBSaleInfoResponse"/>实例</returns>
        public async Task<DescribeDCDBSaleInfoResponse> DescribeDCDBSaleInfo(DescribeDCDBSaleInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询升级分布式数据库实例价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBUpgradePriceResponse"/>实例</returns>
        public async Task<DescribeDCDBUpgradePriceResponse> DescribeDCDBUpgradePrice(DescribeDCDBUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeDCDBUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单Id来查询订单关联的分布式数据库实例，和对应的任务流程ID。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOrdersRequest"/></param>
        /// <returns>参考<see cref="DescribeOrdersResponse"/>实例</returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShardSpecRequest"/></param>
        /// <returns>参考<see cref="DescribeShardSpecResponse"/>实例</returns>
        public async Task<DescribeShardSpecResponse> DescribeShardSpec(DescribeShardSpecRequest req)
        {
             JsonResponseModel<DescribeShardSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShardSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShardSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewDCDBInstanceResponse"/>实例</returns>
        public async Task<RenewDCDBInstanceResponse> RenewDCDBInstance(RenewDCDBInstanceRequest req)
        {
             JsonResponseModel<RenewDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeDCDBInstanceResponse"/>实例</returns>
        public async Task<UpgradeDCDBInstanceResponse> UpgradeDCDBInstance(UpgradeDCDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
