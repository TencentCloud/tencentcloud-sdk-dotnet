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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLabelResponse : AbstractModel
    {
        
        /// <summary>
        /// Web网络版标签结果数组。如未选择WEB场景，则为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public DetectLabelItem[] Labels{ get; set; }

        /// <summary>
        /// Camera摄像头版标签结果数组。如未选择CAMERA场景，则为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CameraLabels")]
        public DetectLabelItem[] CameraLabels{ get; set; }

        /// <summary>
        /// Album相册版标签结果数组。如未选择ALBUM场景，则为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbumLabels")]
        public DetectLabelItem[] AlbumLabels{ get; set; }

        /// <summary>
        /// News新闻版标签结果数组。如未选择NEWS场景，则为空。
        /// 新闻版目前为测试阶段，暂不提供每个标签的一级、二级分类信息的输出。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewsLabels")]
        public DetectLabelItem[] NewsLabels{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "CameraLabels.", this.CameraLabels);
            this.SetParamArrayObj(map, prefix + "AlbumLabels.", this.AlbumLabels);
            this.SetParamArrayObj(map, prefix + "NewsLabels.", this.NewsLabels);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

