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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulDefenceEvent : AbstractModel
    {
        
        /// <summary>
        /// 漏洞ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 漏洞事件id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 主机quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 0: 尝试攻击(WeDetect) 1:尝试攻击成功(WeDetect) 2:rasp防御事件
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }

        /// <summary>
        /// 攻击源ip
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 攻击源ip地址所在城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 攻击源端口
        /// </summary>
        [JsonProperty("SourcePort")]
        public ulong?[] SourcePort{ get; set; }

        /// <summary>
        /// 创建事件时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新事件时间
        /// </summary>
        [JsonProperty("MergeTime")]
        public string MergeTime{ get; set; }

        /// <summary>
        /// 事件发生次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 状态 0: 待处理 1:已防御 2:已处理 3: 已忽略 4: 已删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0 专业版,1 旗舰版,2 LH轻量版（仅限LH使用）,3  CVM轻量版（仅限CVM使用）
        /// </summary>
        [JsonProperty("UpgradeType")]
        public long? UpgradeType{ get; set; }

        /// <summary>
        /// 0 不支持修复，1 支持修复
        /// </summary>
        [JsonProperty("FixType")]
        public long? FixType{ get; set; }

        /// <summary>
        /// 主机uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机额外信息
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamArraySimple(map, prefix + "SourcePort.", this.SourcePort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MergeTime", this.MergeTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamSimple(map, prefix + "FixType", this.FixType);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

