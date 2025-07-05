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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteTrainingModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("TrainingModelId")]
        public string TrainingModelId{ get; set; }

        /// <summary>
        /// 是否同步清理cos
        /// </summary>
        [JsonProperty("EnableDeleteCos")]
        public bool? EnableDeleteCos{ get; set; }

        /// <summary>
        /// 删除模型类型，枚举值：NORMAL 普通，ACCELERATE 加速，不传则删除所有
        /// </summary>
        [JsonProperty("ModelVersionType")]
        public string ModelVersionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrainingModelId", this.TrainingModelId);
            this.SetParamSimple(map, prefix + "EnableDeleteCos", this.EnableDeleteCos);
            this.SetParamSimple(map, prefix + "ModelVersionType", this.ModelVersionType);
        }
    }
}

