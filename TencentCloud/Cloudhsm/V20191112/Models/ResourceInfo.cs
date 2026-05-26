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

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>资源Id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>资源名称</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>资源状态，1-正常，2-隔离，3-销毁</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>资源IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>资源所属Vpc</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>资源所属子网</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>资源所属HSM规格</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>云加密机类型id</p>
        /// </summary>
        [JsonProperty("VsmType")]
        public long? VsmType{ get; set; }

        /// <summary>
        /// <p>地域Id</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>区域Id</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>过期时间（Epoch Unix Timestamp）</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>地域名</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>区域名</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>实例的安全组列表</p>
        /// </summary>
        [JsonProperty("SgList")]
        public SgUnit[] SgList{ get; set; }

        /// <summary>
        /// <p>子网名称</p>
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// <p>当前实例是否已经过期</p>
        /// </summary>
        [JsonProperty("Expired")]
        public bool? Expired{ get; set; }

        /// <summary>
        /// <p>为正数表示实例距离过期时间还剩余多少秒，为负数表示已经过期多少秒</p>
        /// </summary>
        [JsonProperty("RemainSeconds")]
        public long? RemainSeconds{ get; set; }

        /// <summary>
        /// <p>Vpc名称</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>创建者Uin账号</p>
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }

        /// <summary>
        /// <p>自动续费状态标识， 0-手动续费，1-自动续费，2-到期不续</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>厂商</p>
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// <p>告警状态，0：停用，1：启用</p>
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public long? AlarmStatus{ get; set; }

        /// <summary>
        /// <p>0不支持<br>1关闭<br>2开启</p>
        /// </summary>
        [JsonProperty("PqcStatus")]
        public long? PqcStatus{ get; set; }

        /// <summary>
        /// <p>0关闭，1开启</p>
        /// </summary>
        [JsonProperty("PqcFlag")]
        public long? PqcFlag{ get; set; }

        /// <summary>
        /// <p>环境</p><p>默认值：cloud</p><p>cloud或者cdc</p>
        /// </summary>
        [JsonProperty("DeployEnv")]
        public string DeployEnv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "VsmType", this.VsmType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamArrayObj(map, prefix + "SgList.", this.SgList);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "Expired", this.Expired);
            this.SetParamSimple(map, prefix + "RemainSeconds", this.RemainSeconds);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "AlarmStatus", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "PqcStatus", this.PqcStatus);
            this.SetParamSimple(map, prefix + "PqcFlag", this.PqcFlag);
            this.SetParamSimple(map, prefix + "DeployEnv", this.DeployEnv);
        }
    }
}

