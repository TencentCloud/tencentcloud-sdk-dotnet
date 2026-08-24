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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeFaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 人脸框坐标，依次为左、上、右、下，取值范围为 0 到 1
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }

        /// <summary>
        /// 人脸 ID
        /// </summary>
        [JsonProperty("FaceId")]
        public string FaceId{ get; set; }

        /// <summary>
        /// 人脸裁剪图 URL
        /// </summary>
        [JsonProperty("CropImageURL")]
        public string CropImageURL{ get; set; }

        /// <summary>
        /// 是否为代表人脸
        /// </summary>
        [JsonProperty("IsPrototype")]
        public bool? IsPrototype{ get; set; }

        /// <summary>
        /// 人员 ID
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 创建来源。0：自动识别；1：图片导入
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// 人脸所在画面的毫秒级 UNIX 时间戳
        /// </summary>
        [JsonProperty("TimestampMs")]
        public long? TimestampMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamSimple(map, prefix + "CropImageURL", this.CropImageURL);
            this.SetParamSimple(map, prefix + "IsPrototype", this.IsPrototype);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "TimestampMs", this.TimestampMs);
        }
    }
}

