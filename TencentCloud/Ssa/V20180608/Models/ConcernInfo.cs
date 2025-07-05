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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConcernInfo : AbstractModel
    {
        
        /// <summary>
        /// 关注点类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcernType")]
        public long? ConcernType{ get; set; }

        /// <summary>
        /// 实体类型 1: 非云上IP，2: 云上IP，3: 域名，4: IP，5: 文件，6: 进程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntityType")]
        public long? EntityType{ get; set; }

        /// <summary>
        /// 关注点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Concern")]
        public string Concern{ get; set; }

        /// <summary>
        /// 最近数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatisticsCount")]
        public long? StatisticsCount{ get; set; }

        /// <summary>
        /// IP国家
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpCountry")]
        public string IpCountry{ get; set; }

        /// <summary>
        /// IP省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpProvince")]
        public string IpProvince{ get; set; }

        /// <summary>
        /// 结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 置信度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 服务商
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpIsp")]
        public string IpIsp{ get; set; }

        /// <summary>
        /// 是否基础设施
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpInfrastructure")]
        public string IpInfrastructure{ get; set; }

        /// <summary>
        /// 威胁类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThreatType")]
        public string[] ThreatType{ get; set; }

        /// <summary>
        /// 威胁团伙
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Groups")]
        public string[] Groups{ get; set; }

        /// <summary>
        /// 状态威胁情报接口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 恶意标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VictimAssetType")]
        public string VictimAssetType{ get; set; }

        /// <summary>
        /// 资产名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VictimAssetName")]
        public string VictimAssetName{ get; set; }

        /// <summary>
        /// 注册者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainRegistrant")]
        public string DomainRegistrant{ get; set; }

        /// <summary>
        /// 注册机构
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainRegisteredInstitution")]
        public string DomainRegisteredInstitution{ get; set; }

        /// <summary>
        /// 注册时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainRegistrationTime")]
        public string DomainRegistrationTime{ get; set; }

        /// <summary>
        /// 文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 病毒名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 文件路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// 进程名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcName")]
        public string ProcName{ get; set; }

        /// <summary>
        /// 进程ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// 进程路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcPath")]
        public string ProcPath{ get; set; }

        /// <summary>
        /// 用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcUser")]
        public string ProcUser{ get; set; }

        /// <summary>
        /// 已防御
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefendedCount")]
        public ulong? DefendedCount{ get; set; }

        /// <summary>
        /// 仅检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectedCount")]
        public ulong? DetectedCount{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchData")]
        public string SearchData{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpCountryIso")]
        public string IpCountryIso{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpProvinceIso")]
        public string IpProvinceIso{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpCity")]
        public string IpCity{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConcernType", this.ConcernType);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "Concern", this.Concern);
            this.SetParamSimple(map, prefix + "StatisticsCount", this.StatisticsCount);
            this.SetParamSimple(map, prefix + "IpCountry", this.IpCountry);
            this.SetParamSimple(map, prefix + "IpProvince", this.IpProvince);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "IpIsp", this.IpIsp);
            this.SetParamSimple(map, prefix + "IpInfrastructure", this.IpInfrastructure);
            this.SetParamArraySimple(map, prefix + "ThreatType.", this.ThreatType);
            this.SetParamArraySimple(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VictimAssetType", this.VictimAssetType);
            this.SetParamSimple(map, prefix + "VictimAssetName", this.VictimAssetName);
            this.SetParamSimple(map, prefix + "DomainRegistrant", this.DomainRegistrant);
            this.SetParamSimple(map, prefix + "DomainRegisteredInstitution", this.DomainRegisteredInstitution);
            this.SetParamSimple(map, prefix + "DomainRegistrationTime", this.DomainRegistrationTime);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "ProcName", this.ProcName);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "ProcPath", this.ProcPath);
            this.SetParamSimple(map, prefix + "ProcUser", this.ProcUser);
            this.SetParamSimple(map, prefix + "DefendedCount", this.DefendedCount);
            this.SetParamSimple(map, prefix + "DetectedCount", this.DetectedCount);
            this.SetParamSimple(map, prefix + "SearchData", this.SearchData);
            this.SetParamSimple(map, prefix + "IpCountryIso", this.IpCountryIso);
            this.SetParamSimple(map, prefix + "IpProvinceIso", this.IpProvinceIso);
            this.SetParamSimple(map, prefix + "IpCity", this.IpCity);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
        }
    }
}

