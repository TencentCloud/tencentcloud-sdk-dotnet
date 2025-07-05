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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BodyJointsResult : AbstractModel
    {
        
        /// <summary>
        /// 图中检测出来的人体框。
        /// </summary>
        [JsonProperty("BoundBox")]
        public BoundRect BoundBox{ get; set; }

        /// <summary>
        /// 14个人体关键点的坐标，人体关键点详见KeyPointInfo。
        /// </summary>
        [JsonProperty("BodyJoints")]
        public KeyPointInfo[] BodyJoints{ get; set; }

        /// <summary>
        /// 检测出的人体置信度，0-1之间，数值越高越准确。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BoundBox.", this.BoundBox);
            this.SetParamArrayObj(map, prefix + "BodyJoints.", this.BodyJoints);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

