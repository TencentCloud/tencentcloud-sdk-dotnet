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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamMonitorOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// 监播任务输出流宽度像素。范围[1,1920]。建议至少大于100像素。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStreamWidth")]
        public ulong? OutputStreamWidth{ get; set; }

        /// <summary>
        /// 监播任务输出流长度像素。范围[1,1080]，建议至少大于100像素。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStreamHeight")]
        public ulong? OutputStreamHeight{ get; set; }

        /// <summary>
        /// 监播任务输出流名称。
        /// 不填时，系统会自动生成。
        /// 256字节以内，只允许包含字母、数字、‘-’，‘_’，'.'字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStreamName")]
        public string OutputStreamName{ get; set; }

        /// <summary>
        /// 监播任务播放域名。128字节以内，只允许填处于启用状态的播放域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputDomain")]
        public string OutputDomain{ get; set; }

        /// <summary>
        /// 监播任务播放路径。32字节以内，只允许包含字母、数字、‘-’，‘_’，'.'字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputApp")]
        public string OutputApp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputStreamWidth", this.OutputStreamWidth);
            this.SetParamSimple(map, prefix + "OutputStreamHeight", this.OutputStreamHeight);
            this.SetParamSimple(map, prefix + "OutputStreamName", this.OutputStreamName);
            this.SetParamSimple(map, prefix + "OutputDomain", this.OutputDomain);
            this.SetParamSimple(map, prefix + "OutputApp", this.OutputApp);
        }
    }
}

