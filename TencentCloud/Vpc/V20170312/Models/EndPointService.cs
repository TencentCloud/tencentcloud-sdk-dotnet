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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndPointService : AbstractModel
    {
        
        /// <summary>
        /// 终端节点服务ID
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// VPCID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// APPID。
        /// </summary>
        [JsonProperty("ServiceOwner")]
        public string ServiceOwner{ get; set; }

        /// <summary>
        /// 终端节点服务名称。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 后端服务的VIP。
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// 后端服务的ID，比如lb-lip4e6bp。
        /// </summary>
        [JsonProperty("ServiceInstanceId")]
        public string ServiceInstanceId{ get; set; }

        /// <summary>
        /// 是否自动接受。
        /// </summary>
        [JsonProperty("AutoAcceptFlag")]
        public bool? AutoAcceptFlag{ get; set; }

        /// <summary>
        /// 关联的终端节点个数。
        /// </summary>
        [JsonProperty("EndPointCount")]
        public ulong? EndPointCount{ get; set; }

        /// <summary>
        /// 终端节点对象数组。
        /// </summary>
        [JsonProperty("EndPointSet")]
        public EndPoint[] EndPointSet{ get; set; }

        /// <summary>
        /// 创建时间。格式为YYYY-MM-DD HH:MM:SS字符串。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 挂载的PAAS服务类型，CLB（负载均衡），CDB（云数据库 MySQL），CRS（云数据库 Redis），GWLB（网关负载均衡）。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// CDC 集群唯一 ID
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// 终端节点服务Uin。
        /// </summary>
        [JsonProperty("ServiceUin")]
        public string ServiceUin{ get; set; }

        /// <summary>
        /// 服务IP类型
        /// </summary>
        [JsonProperty("BusinessIpType")]
        public long? BusinessIpType{ get; set; }

        /// <summary>
        /// 标签键值对。	
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ServiceOwner", this.ServiceOwner);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceVip", this.ServiceVip);
            this.SetParamSimple(map, prefix + "ServiceInstanceId", this.ServiceInstanceId);
            this.SetParamSimple(map, prefix + "AutoAcceptFlag", this.AutoAcceptFlag);
            this.SetParamSimple(map, prefix + "EndPointCount", this.EndPointCount);
            this.SetParamArrayObj(map, prefix + "EndPointSet.", this.EndPointSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "ServiceUin", this.ServiceUin);
            this.SetParamSimple(map, prefix + "BusinessIpType", this.BusinessIpType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

