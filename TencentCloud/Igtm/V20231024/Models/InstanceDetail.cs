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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 业务域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Cname域名接入方式
        /// CUSTOM: 自定义接入域名
        /// SYSTEM: 系统接入域名
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 接入子域名	
        /// </summary>
        [JsonProperty("AccessSubDomain")]
        public string AccessSubDomain{ get; set; }

        /// <summary>
        /// 接入域名	
        /// </summary>
        [JsonProperty("AccessDomain")]
        public string AccessDomain{ get; set; }

        /// <summary>
        /// 解析生效时间
        /// </summary>
        [JsonProperty("GlobalTtl")]
        public ulong? GlobalTtl{ get; set; }

        /// <summary>
        /// 套餐类型
        /// FREE: 免费版
        /// STANDARD：标准版
        /// ULTIMATE：旗舰版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 实例运行状态
        /// NORMAL: 健康
        /// FAULTY: 有风险
        /// DOWN: 宕机
        /// UNKNOWN: 未知
        /// </summary>
        [JsonProperty("WorkingStatus")]
        public string WorkingStatus{ get; set; }

        /// <summary>
        /// 实例状态
        /// ENABLED: 正常
        /// DISABLED: 禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// cname是否接入：true已接入；false未接入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCnameConfigured")]
        public bool? IsCnameConfigured{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 策略数量
        /// </summary>
        [JsonProperty("StrategyNum")]
        public long? StrategyNum{ get; set; }

        /// <summary>
        /// 绑定地址池个数
        /// </summary>
        [JsonProperty("AddressPoolNum")]
        public long? AddressPoolNum{ get; set; }

        /// <summary>
        /// 绑定监控器数量
        /// </summary>
        [JsonProperty("MonitorNum")]
        public long? MonitorNum{ get; set; }

        /// <summary>
        /// 实例绑定套餐资源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 订阅事件列表
        /// </summary>
        [JsonProperty("NotifyEventSet")]
        public string[] NotifyEventSet{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 实例更新时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "AccessSubDomain", this.AccessSubDomain);
            this.SetParamSimple(map, prefix + "AccessDomain", this.AccessDomain);
            this.SetParamSimple(map, prefix + "GlobalTtl", this.GlobalTtl);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "WorkingStatus", this.WorkingStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsCnameConfigured", this.IsCnameConfigured);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "StrategyNum", this.StrategyNum);
            this.SetParamSimple(map, prefix + "AddressPoolNum", this.AddressPoolNum);
            this.SetParamSimple(map, prefix + "MonitorNum", this.MonitorNum);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "NotifyEventSet.", this.NotifyEventSet);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
        }
    }
}

