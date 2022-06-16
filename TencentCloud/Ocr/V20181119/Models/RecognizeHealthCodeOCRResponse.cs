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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeHealthCodeOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 持码人姓名，如：王*（允许返回空值）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 持码人身份证号，如：11**************01（允许返回空值）
        /// </summary>
        [JsonProperty("IDNumber")]
        public string IDNumber{ get; set; }

        /// <summary>
        /// 健康码更新时间（允许返回空值）
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 健康码颜色：绿色、黄色、红色（允许返回空值）
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 核酸检测间隔时长（允许返回空值）
        /// </summary>
        [JsonProperty("TestingInterval")]
        public string TestingInterval{ get; set; }

        /// <summary>
        /// 核酸检测结果：阴性、阳性、暂无核酸检测记录（允许返回空值）
        /// </summary>
        [JsonProperty("TestingResult")]
        public string TestingResult{ get; set; }

        /// <summary>
        /// 核酸检测时间（允许返回空值）
        /// </summary>
        [JsonProperty("TestingTime")]
        public string TestingTime{ get; set; }

        /// <summary>
        /// 疫苗接种信息，返回接种针数或接种情况（允许返回空值）
        /// </summary>
        [JsonProperty("Vaccination")]
        public string Vaccination{ get; set; }

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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IDNumber", this.IDNumber);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "TestingInterval", this.TestingInterval);
            this.SetParamSimple(map, prefix + "TestingResult", this.TestingResult);
            this.SetParamSimple(map, prefix + "TestingTime", this.TestingTime);
            this.SetParamSimple(map, prefix + "Vaccination", this.Vaccination);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

