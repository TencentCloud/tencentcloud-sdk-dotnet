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

    public class PageScreenListVO : AbstractModel
    {
        
        /// <summary>
        /// 图片导出类型。base64；url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PicType")]
        public string PicType{ get; set; }

        /// <summary>
        /// 图片列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("List")]
        public PageScreenVO[] List{ get; set; }

        /// <summary>
        /// 异步事务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }

        /// <summary>
        /// 事务状态
        /// 1: 处理中; 2: 处理成功; 3 处理失败(错误内容见外层Msg)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranStatus")]
        public long? TranStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PicType", this.PicType);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
        }
    }
}

