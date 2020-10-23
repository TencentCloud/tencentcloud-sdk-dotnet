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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceListResponse : AbstractModel
    {
        
        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 资源记录列表，返回Key值说明：
        /// "Key": "CreateTime" 表示资源实例购买时间
        /// "Key": "Region" 表示资源实例的地域
        /// "Key": "BoundIP" 表示独享包实例绑定的IP
        /// "Key": "Id" 表示资源实例的ID
        /// "Key": "CCEnabled" 表示资源实例的CC防护开关状态
        /// "Key": "DDoSThreshold" 表示资源实例的DDoS的清洗阈值	
        /// "Key": "BoundStatus" 表示独享包或共享包实例的绑定IP操作状态(绑定中或绑定完成)
        /// "Key": "Type" 此字段弃用
        /// "Key": "ElasticLimit" 表示资源实例的弹性防护值
        /// "Key": "DDoSAI" 表示资源实例的DDoS AI防护开关
        /// "Key": "Bandwidth" 表示资源实例的保底防护值
        /// "Key": "OverloadCount" 表示资源实例受到超过弹性防护值的次数
        /// "Key": "Status" 表示资源实例的状态(idle:运行中, attacking:攻击中, blocking:封堵中, isolate:隔离中)
        /// "Key": "Lbid" 此字段弃用
        /// "Key": "ShowFlag" 此字段弃用
        /// "Key": "Expire" 表示资源实例的过期时间
        /// "Key": "CCThreshold" 表示资源实例的CC防护触发阈值
        /// "Key": "AutoRenewFlag" 表示资源实例的自动续费是否开启
        /// "Key": "IspCode" 表示独享包或共享包的线路(0-电信, 1-联通, 2-移动, 5-BGP)
        /// "Key": "PackType" 表示套餐包类型
        /// "Key": "PackId" 表示套餐包ID
        /// "Key": "Name" 表示资源实例的名称
        /// "Key": "Locked" 此字段弃用
        /// "Key": "IpDDoSLevel" 表示资源实例的防护等级(low-宽松, middle-正常, high-严格)
        /// "Key": "DefendStatus" 表示资源实例的DDoS防护状态(防护开启或临时关闭)
        /// "Key": "UndefendExpire" 表示资源实例的DDoS防护临时关闭结束时间
        /// "Key": "Tgw" 表示资源实例是否是新资源
        /// </summary>
        [JsonProperty("ServicePacks")]
        public KeyValueRecord[] ServicePacks{ get; set; }

        /// <summary>
        /// 大禹子产品代号（bgp表示独享包；bgp-multip表示共享包；bgpip表示高防IP；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "ServicePacks.", this.ServicePacks);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

