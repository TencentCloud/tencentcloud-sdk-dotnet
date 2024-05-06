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

    public class DashboardSubscribeData : AbstractModel
    {
        
        /// <summary>
        /// 仪表盘订阅通知方式。
        /// </summary>
        [JsonProperty("NoticeModes")]
        public DashboardNoticeMode[] NoticeModes{ get; set; }

        /// <summary>
        /// 仪表盘订阅时间，为空标识取仪表盘默认的时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DashboardTime")]
        public string[] DashboardTime{ get; set; }

        /// <summary>
        /// 仪表盘订阅模板变量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateVariables")]
        public DashboardTemplateVariable[] TemplateVariables{ get; set; }

        /// <summary>
        /// 时区。参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#SHANGHAI
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }

        /// <summary>
        /// 语言。 zh 中文、en`英文。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscribeLanguage")]
        public string SubscribeLanguage{ get; set; }

        /// <summary>
        /// 调用链接域名。http:// 或者 https:// 开头，不能/结尾
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// 自定义跳转链接。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NoticeModes.", this.NoticeModes);
            this.SetParamArraySimple(map, prefix + "DashboardTime.", this.DashboardTime);
            this.SetParamArrayObj(map, prefix + "TemplateVariables.", this.TemplateVariables);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
            this.SetParamSimple(map, prefix + "SubscribeLanguage", this.SubscribeLanguage);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
        }
    }
}

