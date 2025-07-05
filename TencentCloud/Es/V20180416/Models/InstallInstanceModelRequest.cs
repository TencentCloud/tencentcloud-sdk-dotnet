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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallInstanceModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 客户上传到cos的模型地址，单次请求限制一个。cos文件为压缩文件，格式包括：zip、tgz和tar.gz
        /// </summary>
        [JsonProperty("UsrCosModelUrlList")]
        public string[] UsrCosModelUrlList{ get; set; }

        /// <summary>
        /// 客户指定安装的模型名称，可为空，默认为模型文件名
        /// </summary>
        [JsonProperty("ModelNames")]
        public string[] ModelNames{ get; set; }

        /// <summary>
        /// 模型使用的任务类型，包括：fill_mask, ner, question_answering, text_classification, text_embedding, text_expansion, text_similarity和zero_shot_classification，默认为text_embedding
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "UsrCosModelUrlList.", this.UsrCosModelUrlList);
            this.SetParamArraySimple(map, prefix + "ModelNames.", this.ModelNames);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
        }
    }
}

