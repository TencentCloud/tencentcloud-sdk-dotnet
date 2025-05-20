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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLogstashInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称（1-50 个英文、汉字、数字、连接线-或下划线_）
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例版本（支持"6.8.13"、"7.10.1"）
        /// </summary>
        [JsonProperty("LogstashVersion")]
        public string LogstashVersion{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 节点数量（2-50个）
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 计费类型<li>PREPAID：预付费，即包年包月</li><li>POSTPAID_BY_HOUR：按小时后付费</li>默认值POSTPAID_BY_HOUR
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 包年包月购买时长（单位由参数TimeUnit决定）
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// 计费时长单位（ChargeType为PREPAID时需要设置，默认值为“m”，表示月，当前只支持“m”）
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 是否自动使用代金券<li>0：不自动使用</li><li>1：自动使用</li>默认值0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表（目前仅支持指定一张代金券）
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 自动续费标识<li>RENEW_FLAG_AUTO：自动续费</li><li>RENEW_FLAG_MANUAL：不自动续费，用户手动续费</li>ChargeType为PREPAID时需要设置，如不传递该参数，普通用户默认不自动续费，SVIP用户自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 节点规格<li>LOGSTASH.S1.SMALL2：1核2G</li><li>LOGSTASH.S1.MEDIUM4：2核4G</li><li>LOGSTASH.S1.MEDIUM8：2核8G</li><li>LOGSTASH.S1.LARGE16：4核16G</li><li>LOGSTASH.S1.2XLARGE32：8核32G</li><li>LOGSTASH.S1.4XLARGE32：16核32G</li><li>LOGSTASH.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点磁盘类型<li>CLOUD_SSD：SSD云硬盘</li><li>CLOUD_PREMIUM：高硬能云硬盘</li>默认值CLOUD_SSD
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 节点磁盘容量（单位GB）
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// License类型<li>oss：开源版</li><li>xpack：xpack版</li>默认值xpack
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 标签信息列表
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// 可维护时间段
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDuration OperationDuration{ get; set; }

        /// <summary>
        /// 多可用区部署时可用区的详细信息
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// 部署模式，0：单可用区、1：多可用区
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "LogstashVersion", this.LogstashVersion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ChargePeriod", this.ChargePeriod);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
        }
    }
}

