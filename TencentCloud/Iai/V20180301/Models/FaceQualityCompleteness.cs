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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceQualityCompleteness : AbstractModel
    {
        
        /// <summary>
        /// 眉毛的遮挡分数[0,100]，分数越高遮挡越少。 
        /// 参考范围：[0,80]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Eyebrow")]
        public long? Eyebrow{ get; set; }

        /// <summary>
        /// 眼睛的遮挡分数[0,100],分数越高遮挡越少。 
        /// 参考范围：[0,80]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Eye")]
        public long? Eye{ get; set; }

        /// <summary>
        /// 鼻子的遮挡分数[0,100],分数越高遮挡越少。 
        /// 参考范围：[0,60]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nose")]
        public long? Nose{ get; set; }

        /// <summary>
        /// 脸颊的遮挡分数[0,100],分数越高遮挡越少。 
        /// 参考范围：[0,70]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cheek")]
        public long? Cheek{ get; set; }

        /// <summary>
        /// 嘴巴的遮挡分数[0,100],分数越高遮挡越少。 
        /// 参考范围：[0,50]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mouth")]
        public long? Mouth{ get; set; }

        /// <summary>
        /// 下巴的遮挡分数[0,100],分数越高遮挡越少。 
        /// 参考范围：[0,70]表示发生遮挡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Chin")]
        public long? Chin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Eyebrow", this.Eyebrow);
            this.SetParamSimple(map, prefix + "Eye", this.Eye);
            this.SetParamSimple(map, prefix + "Nose", this.Nose);
            this.SetParamSimple(map, prefix + "Cheek", this.Cheek);
            this.SetParamSimple(map, prefix + "Mouth", this.Mouth);
            this.SetParamSimple(map, prefix + "Chin", this.Chin);
        }
    }
}

