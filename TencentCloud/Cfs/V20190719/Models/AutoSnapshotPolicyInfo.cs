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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoSnapshotPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 快照策略ID
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// 快照策略ID
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 快照策略创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 关联的文件系统个数
        /// </summary>
        [JsonProperty("FileSystemNums")]
        public ulong? FileSystemNums{ get; set; }

        /// <summary>
        /// 快照定期备份在一星期哪一天，该参数与DayOfMonth,IntervalDays互斥
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// 快照定期备份在一天的哪一小时
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// 是否激活定期快照功能
        /// </summary>
        [JsonProperty("IsActivated")]
        public ulong? IsActivated{ get; set; }

        /// <summary>
        /// 下一次触发快照时间
        /// </summary>
        [JsonProperty("NextActiveTime")]
        public string NextActiveTime{ get; set; }

        /// <summary>
        /// 快照策略状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 帐号ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 保留时间
        /// </summary>
        [JsonProperty("AliveDays")]
        public ulong? AliveDays{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 文件系统信息
        /// </summary>
        [JsonProperty("FileSystems")]
        public FileSystemByPolicy[] FileSystems{ get; set; }

        /// <summary>
        /// 快照定期备份在一个月的某个时间；该参数与DayOfWeek,IntervalDays互斥
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DayOfMonth")]
        public string DayOfMonth{ get; set; }

        /// <summary>
        /// 快照定期间隔天数，1-365 天；该参数与DayOfMonth,DayOfWeek互斥
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalDays")]
        public ulong? IntervalDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "FileSystemNums", this.FileSystemNums);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "NextActiveTime", this.NextActiveTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AliveDays", this.AliveDays);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamArrayObj(map, prefix + "FileSystems.", this.FileSystems);
            this.SetParamSimple(map, prefix + "DayOfMonth", this.DayOfMonth);
            this.SetParamSimple(map, prefix + "IntervalDays", this.IntervalDays);
        }
    }
}

