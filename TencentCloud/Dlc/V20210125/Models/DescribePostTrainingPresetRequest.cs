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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePostTrainingPresetRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>使用的大模型微调算法</p><p>枚举值：</p><ul><li>sft： Supervised Fine-Tuning，监督微调</li><li>dpo： Direct Preference Optimization，模型偏好训练微调</li><li>grpo： Group Relative Policy Optimization，组相对策略优化</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>训练模式，会根据不同训练模式推荐不同的训练参数</p><p>枚举值：</p><ul><li>balanced： 均衡模式，标准配置，兼顾训练速度和模型效果</li><li>quality： 质量优先，更低学习率 / 更多轮次 / 更大 LoRA rank，追求最佳效果</li><li>speed： 速度优先，大 batch / 关闭 grad_ckpt / 短序列，最快迭代验证</li><li>custom： 自定义模式，手动调整各项参数</li></ul><p>默认值：balanced</p>
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// <p>参数微调方式</p><p>枚举值：</p><ul><li>lora： 轻量级微调大模型的方法</li><li>full： 全参数大模型微调</li></ul>
        /// </summary>
        [JsonProperty("FineTuneType")]
        public string FineTuneType{ get; set; }

        /// <summary>
        /// <p>模型参数大小，如 0.8B，就是 0.8的参数量。370B 模型，就是 370</p>
        /// </summary>
        [JsonProperty("ParameterSize")]
        public float? ParameterSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamSimple(map, prefix + "FineTuneType", this.FineTuneType);
            this.SetParamSimple(map, prefix + "ParameterSize", this.ParameterSize);
        }
    }
}

