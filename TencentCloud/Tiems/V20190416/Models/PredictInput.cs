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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PredictInput : AbstractModel
    {
        
        /// <summary>
        /// 输入路径，支持 cos 格式路径文件夹或文件
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }

        /// <summary>
        /// 输出路径，支持 cos 格式路径
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// 输入数据格式，目前支持：JSON
        /// </summary>
        [JsonProperty("InputDataFormat")]
        public string InputDataFormat{ get; set; }

        /// <summary>
        /// 输出数据格式，目前支持：JSON
        /// </summary>
        [JsonProperty("OutputDataFormat")]
        public string OutputDataFormat{ get; set; }

        /// <summary>
        /// 预测批大小，默认为 64
        /// </summary>
        [JsonProperty("BatchSize")]
        public ulong? BatchSize{ get; set; }

        /// <summary>
        /// 模型签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignatureName")]
        public string SignatureName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "InputDataFormat", this.InputDataFormat);
            this.SetParamSimple(map, prefix + "OutputDataFormat", this.OutputDataFormat);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "SignatureName", this.SignatureName);
        }
    }
}

