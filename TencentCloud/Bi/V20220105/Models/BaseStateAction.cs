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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseStateAction : AbstractModel
    {
        
        /// <summary>
        /// 编辑是否可见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowEdit")]
        public bool? ShowEdit{ get; set; }

        /// <summary>
        /// 编辑是否可点击
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEdit")]
        public bool? IsEdit{ get; set; }

        /// <summary>
        /// 编辑按钮的文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EditText")]
        public string EditText{ get; set; }

        /// <summary>
        /// 编辑不可用时的提示文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EditTips")]
        public string EditTips{ get; set; }

        /// <summary>
        /// 删除是否可见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowDel")]
        public bool? ShowDel{ get; set; }

        /// <summary>
        /// 删除是否可点击
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDel")]
        public bool? IsDel{ get; set; }

        /// <summary>
        /// 删除按钮的文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelText")]
        public string DelText{ get; set; }

        /// <summary>
        /// 删除不可用时的提示文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelTips")]
        public string DelTips{ get; set; }

        /// <summary>
        /// 复制是否可见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowCopy")]
        public bool? ShowCopy{ get; set; }

        /// <summary>
        /// 是否可见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowView")]
        public bool? ShowView{ get; set; }

        /// <summary>
        /// 是否可重命名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowRename")]
        public bool? ShowRename{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowEdit", this.ShowEdit);
            this.SetParamSimple(map, prefix + "IsEdit", this.IsEdit);
            this.SetParamSimple(map, prefix + "EditText", this.EditText);
            this.SetParamSimple(map, prefix + "EditTips", this.EditTips);
            this.SetParamSimple(map, prefix + "ShowDel", this.ShowDel);
            this.SetParamSimple(map, prefix + "IsDel", this.IsDel);
            this.SetParamSimple(map, prefix + "DelText", this.DelText);
            this.SetParamSimple(map, prefix + "DelTips", this.DelTips);
            this.SetParamSimple(map, prefix + "ShowCopy", this.ShowCopy);
            this.SetParamSimple(map, prefix + "ShowView", this.ShowView);
            this.SetParamSimple(map, prefix + "ShowRename", this.ShowRename);
        }
    }
}

