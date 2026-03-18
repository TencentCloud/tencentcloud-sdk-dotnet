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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerificationConfig : AbstractModel
    {
        
        /// <summary>
        /// 短信验证码发送通道类型。取值范围：
        /// default：使用默认云开发短信包发送短信。
        /// apis：使用云开发自定义 APIs 作为短信发送通道，需配合 Name 和 Method 参数使用。
        /// 不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 自定义 APIs 数据源唯一标识，当 Type 为 apis 时必填。用于定位微搭 APIs 中对应的数据源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 自定义 APIs 方法名，当 Type 为 apis 时必填。指定微搭 APIs 中用于发送验证码的方法。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 单个手机号每日短信发送上限。默认值为 30，传 -1 表示不限制，如果设置为不限制，需要注意恶意攻击，导致短信套餐用量计费问题。仅支持正整数或 -1。不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsDayLimit")]
        public long? SmsDayLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "SmsDayLimit", this.SmsDayLimit);
        }
    }
}

