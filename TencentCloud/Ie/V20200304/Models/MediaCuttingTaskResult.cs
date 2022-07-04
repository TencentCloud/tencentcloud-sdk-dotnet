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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 如果ResultListType不为NoListFile时，结果（TaskResultFile）列表文件的存储位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListFile")]
        public TaskResultFile ListFile{ get; set; }

        /// <summary>
        /// 结果个数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultCount")]
        public long? ResultCount{ get; set; }

        /// <summary>
        /// 第一个结果文件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstFile")]
        public TaskResultFile FirstFile{ get; set; }

        /// <summary>
        /// 最后一个结果文件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastFile")]
        public TaskResultFile LastFile{ get; set; }

        /// <summary>
        /// 任务结果包含的图片总数。
        /// 静态图：总数即为文件数；
        /// 雪碧图：所有小图总数；
        /// 动图、视频：不计算图片数，为 0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageCount")]
        public long? ImageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ListFile.", this.ListFile);
            this.SetParamSimple(map, prefix + "ResultCount", this.ResultCount);
            this.SetParamObj(map, prefix + "FirstFile.", this.FirstFile);
            this.SetParamObj(map, prefix + "LastFile.", this.LastFile);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
        }
    }
}

