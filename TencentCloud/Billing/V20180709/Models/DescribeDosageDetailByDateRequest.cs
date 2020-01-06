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
        /// 10180：CDN静态加速流量(国内)
        /// 10181：CDN静态加速带宽(国内)
        /// 10182：CDN静态加速普通流量
        /// 10183：CDN静态加速普通带宽
        /// 10231：CDN静态加速流量(海外)
        /// 10232：CDN静态加速带宽(海外)
        /// 
        /// 100967：弹性公网IP-按流量计费
        /// 101065：公网负载均衡-按流量计费
        /// 
        /// 视频直播
        /// 10226 视频直播流量(国内)
        /// 10227 视频直播带宽(国内)
        /// 100763 视频直播流量(海外)
        /// 100762 视频直播宽带(海外)
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 查询域名 例如 www.qq.com
        /// 非CDN业务查询时值为空
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

