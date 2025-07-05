/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDosageDetailByDateRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询账单开始日期，如 2019-01-01
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 查询账单结束日期，如 2019-01-01， 时间跨度不超过7天
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 互动直播：
        /// 10194   互动直播-核心机房           :
        /// 10195   互动直播-边缘机房
        /// 
        /// cdn业务：
        /// 102383：CDN静态加速流量(国内)
        /// 102384：CDN静态加速带宽(国内)
        /// 102385：CDN静态加速流量(海外)
        /// 102386：CDN静态加速带宽(海外)
        /// 
        /// 100967：弹性公网IP-按流量计费
        /// 101065：公网负载均衡-按流量计费
        /// 
        /// 视频直播
        /// 10226 视频直播流量(国内)
        /// 10227 视频直播带宽(国内)
        /// 100763 视频直播流量(海外)
        /// 100762 视频直播宽带(海外)
        /// 
        /// 仅支持以上产品
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 查询域名 例如 www.qq.com
        /// 非CDN业务查询时传入空字符串，返回的值为空
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 1、如果为空，则返回EIP或CLB所有实例的明细；
        /// 2、如果传入实例名，则返回该实例明细
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 支付者的账号 ID（账号 ID 是用户在腾讯云的唯一账号标识），默认查询本账号账单，如集团管理账号需查询成员账号自付的账单，该字段需入参成员账号UIN
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
        }
    }
}

