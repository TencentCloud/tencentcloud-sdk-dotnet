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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrainingModelVersionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("TrainingModelId")]
        public string TrainingModelId{ get; set; }

        /// <summary>
        /// 过滤条件
        /// Filter.Name: 枚举值:
        ///     TrainingModelVersionId (模型版本ID)
        ///     ModelVersionType (模型版本类型) 其值支持: NORMAL(通用) ACCELERATE (加速)
        ///     ModelFormat（模型格式）其值Filter.Values支持：
        /// TORCH_SCRIPT/PYTORCH/DETECTRON2/SAVED_MODEL/FROZEN_GRAPH/PMML
        ///     AlgorithmFramework (算法框架) 其值Filter.Values支持：TENSORFLOW/PYTORCH/DETECTRON2
        /// Filter.Values: 当长度为1时，支持模糊查询; 不为1时，精确查询
        /// 每次请求的Filters的上限为10，Filter.Values的上限为100
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrainingModelId", this.TrainingModelId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

