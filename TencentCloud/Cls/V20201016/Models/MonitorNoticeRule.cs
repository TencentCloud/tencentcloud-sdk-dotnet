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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorNoticeRule : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云可观测平台通知模板 ID
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }

        /// <summary>
        /// 腾讯云可观测平台内容模板ID，不传默认内容模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentTmplId")]
        public string ContentTmplId{ get; set; }

        /// <summary>
        /// 告警级别,0:警告(Warn); 1:提醒(Info); 2:紧急 (Critical)
        /// </summary>
        [JsonProperty("AlarmLevels")]
        public ulong?[] AlarmLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
            this.SetParamSimple(map, prefix + "ContentTmplId", this.ContentTmplId);
            this.SetParamArraySimple(map, prefix + "AlarmLevels.", this.AlarmLevels);
        }
    }
}

