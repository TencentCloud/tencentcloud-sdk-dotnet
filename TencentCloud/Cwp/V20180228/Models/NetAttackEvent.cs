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

    public class NetAttackEvent : AbstractModel
    {
        
        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 目标端口
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// 来源IP
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// 来源地
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 攻击时间
        /// </summary>
        [JsonProperty("MergeTime")]
        public string MergeTime{ get; set; }

        /// <summary>
        /// 主机额外信息
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// 攻击状态，0: 尝试攻击 1: 实锤攻击(攻击成功)
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 处理状态，0 待处理 1 已处理 2 已加白  3 已忽略 4 已删除 5: 已开启防御
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 漏洞是否支持防御，0:不支持 1:支持
        /// </summary>
        [JsonProperty("VulSupportDefense")]
        public ulong? VulSupportDefense{ get; set; }

        /// <summary>
        /// 是否开启漏洞防御，0关1开
        /// </summary>
        [JsonProperty("VulDefenceStatus")]
        public ulong? VulDefenceStatus{ get; set; }

        /// <summary>
        /// 机器付费版本，0 基础版，1专业版，2旗舰版，3轻量版
        /// </summary>
        [JsonProperty("PayVersion")]
        public ulong? PayVersion{ get; set; }

        /// <summary>
        /// cvm uuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 攻击次数
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 是否今日新增主机
        /// </summary>
        [JsonProperty("New")]
        public bool? New{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "MergeTime", this.MergeTime);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VulSupportDefense", this.VulSupportDefense);
            this.SetParamSimple(map, prefix + "VulDefenceStatus", this.VulDefenceStatus);
            this.SetParamSimple(map, prefix + "PayVersion", this.PayVersion);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "New", this.New);
        }
    }
}

