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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsoleSharingConfig : AbstractModel
    {
        
        /// <summary>
        /// 分享链接名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 仪表盘: 1; 检索页:2
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 分享链接有效期，单位：毫秒，最长支持30天
        /// </summary>
        [JsonProperty("DurationMilliseconds")]
        public ulong? DurationMilliseconds{ get; set; }

        /// <summary>
        /// 允许访问的资源列表
        /// </summary>
        [JsonProperty("Resources")]
        public string[] Resources{ get; set; }

        /// <summary>
        /// 分享链接域名，可选范围
        /// - 公网匿名分享：填写clsshare.com
        /// - datasight内网匿名分享(若开启)：datasight内网域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 验证码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyCode")]
        public string VerifyCode{ get; set; }

        /// <summary>
        /// 默认查询范围的开始时间点，支持绝对时间(13位Unix时间戳)或相对时间表达式
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 默认查询范围的结束时间点，支持绝对时间(13位Unix时间戳)或相对时间表达式。注意，结束时间点要大于开始时间点
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 仅当StartTime/EndTime为相对时间时使用，基于NowTime计算绝对时间，默认为创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NowTime")]
        public ulong? NowTime{ get; set; }

        /// <summary>
        /// 默认的检索分析语句，仅当Type为2时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public ConsoleSharingParam[] Params{ get; set; }

        /// <summary>
        /// 是否允许访问者自行修改检索分析时间范围。默认不锁定（false）
        /// </summary>
        [JsonProperty("IsLockTimeRange")]
        public bool? IsLockTimeRange{ get; set; }

        /// <summary>
        /// 是否允许访问者自行修改日志检索语句。在检索页分享中表示检索语句锁定状态；在仪表盘中表示过滤变量锁定状态。默认不锁定（false）
        /// </summary>
        [JsonProperty("IsLockQuery")]
        public bool? IsLockQuery{ get; set; }

        /// <summary>
        /// 检索页分享是否允许访问者下载日志，默认不允许（false）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportLogExport")]
        public bool? IsSupportLogExport{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DurationMilliseconds", this.DurationMilliseconds);
            this.SetParamArraySimple(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerifyCode", this.VerifyCode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NowTime", this.NowTime);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamSimple(map, prefix + "IsLockTimeRange", this.IsLockTimeRange);
            this.SetParamSimple(map, prefix + "IsLockQuery", this.IsLockQuery);
            this.SetParamSimple(map, prefix + "IsSupportLogExport", this.IsSupportLogExport);
        }
    }
}

