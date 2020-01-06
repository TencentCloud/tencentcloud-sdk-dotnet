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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LipColorInfo : AbstractModel
    {
        
        /// <summary>
        /// 使用RGBA模型试唇色。
        /// </summary>
        [JsonProperty("RGBA")]
        public RGBAInfo RGBA{ get; set; }

        /// <summary>
        /// 使用已注册的 LUT 文件试唇色。  
        /// ModelId 和 RGBA 两个参数只需提供一个，若都提供只使用 ModelId。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 人脸框位置。若不输入则选择 Image 或 Url 中面积最大的人脸。  
        /// 您可以通过 [人脸检测与分析](https://cloud.tencent.com/document/api/867/32800)  接口获取人脸框位置信息。
        /// </summary>
        [JsonProperty("FaceRect")]
        public FaceRect FaceRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RGBA.", this.RGBA);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamObj(map, prefix + "FaceRect.", this.FaceRect);
        }
    }
}

