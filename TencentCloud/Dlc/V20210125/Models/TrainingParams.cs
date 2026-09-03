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

    public class TrainingParams : AbstractModel
    {
        
        /// <summary>
        /// <p>每卡 batch size，SFT/DPO 用。GRPO 返回 null</p>
        /// </summary>
        [JsonProperty("PerDeviceBatchSize")]
        public long? PerDeviceBatchSize{ get; set; }

        /// <summary>
        /// <p>梯度累积步数，用于放大有效 batch；GRPO 返回 null。</p>
        /// </summary>
        [JsonProperty("GradientAccumulationSteps")]
        public long? GradientAccumulationSteps{ get; set; }

        /// <summary>
        /// <p>是否开启梯度检查点（省显存换计算），GRPO 返回 null。</p>
        /// </summary>
        [JsonProperty("GradientCheckpointing")]
        public bool? GradientCheckpointing{ get; set; }

        /// <summary>
        /// <p>最大序列/上下文长度，所有模式都返回。</p>
        /// </summary>
        [JsonProperty("CutoffLen")]
        public long? CutoffLen{ get; set; }

        /// <summary>
        /// <p>推荐学习率；SFT/DPO 按算法+微调方式给值，GRPO 返回 null（由入口脚本默认值决定）。</p>
        /// </summary>
        [JsonProperty("LearningRate")]
        public float? LearningRate{ get; set; }

        /// <summary>
        /// <p>推荐训练轮次，所有模式都返回。</p>
        /// </summary>
        [JsonProperty("Epochs")]
        public long? Epochs{ get; set; }

        /// <summary>
        /// <p>推荐 LoRA rank（仅 finetuneType=lora 有值，全参微调/GRPO 返回 null）。</p>
        /// </summary>
        [JsonProperty("LoraRank")]
        public long? LoraRank{ get; set; }

        /// <summary>
        /// <p>warmup 步数占总步数比例；GRPO 返回 null。</p>
        /// </summary>
        [JsonProperty("WarmupRatio")]
        public float? WarmupRatio{ get; set; }

        /// <summary>
        /// <p>GRPO 每步训练的 prompt 总数；SFT/DPO 返回 null。</p>
        /// </summary>
        [JsonProperty("TrainBatchSize")]
        public long? TrainBatchSize{ get; set; }

        /// <summary>
        /// <p>GRPO PPO 阶段 mini-batch 大小；SFT/DPO 返回 null。</p>
        /// </summary>
        [JsonProperty("PPOMiniBatchSize")]
        public long? PPOMiniBatchSize{ get; set; }

        /// <summary>
        /// <p>GRPO rollout（vLLM/sglang）占用 GPU 显存比例（0~1）；SFT/DPO 返回 null。</p>
        /// </summary>
        [JsonProperty("GpuMemoryUtilization")]
        public float? GpuMemoryUtilization{ get; set; }

        /// <summary>
        /// <p>GRPO rollout 单次最大生成长度；SFT/DPO 返回 null。</p>
        /// </summary>
        [JsonProperty("MaxResponseLength")]
        public long? MaxResponseLength{ get; set; }

        /// <summary>
        /// <p>GRPO 每个 prompt 的采样数（group size）；SFT/DPO 返回 null。</p>
        /// </summary>
        [JsonProperty("NumSamplesPerPrompt")]
        public long? NumSamplesPerPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PerDeviceBatchSize", this.PerDeviceBatchSize);
            this.SetParamSimple(map, prefix + "GradientAccumulationSteps", this.GradientAccumulationSteps);
            this.SetParamSimple(map, prefix + "GradientCheckpointing", this.GradientCheckpointing);
            this.SetParamSimple(map, prefix + "CutoffLen", this.CutoffLen);
            this.SetParamSimple(map, prefix + "LearningRate", this.LearningRate);
            this.SetParamSimple(map, prefix + "Epochs", this.Epochs);
            this.SetParamSimple(map, prefix + "LoraRank", this.LoraRank);
            this.SetParamSimple(map, prefix + "WarmupRatio", this.WarmupRatio);
            this.SetParamSimple(map, prefix + "TrainBatchSize", this.TrainBatchSize);
            this.SetParamSimple(map, prefix + "PPOMiniBatchSize", this.PPOMiniBatchSize);
            this.SetParamSimple(map, prefix + "GpuMemoryUtilization", this.GpuMemoryUtilization);
            this.SetParamSimple(map, prefix + "MaxResponseLength", this.MaxResponseLength);
            this.SetParamSimple(map, prefix + "NumSamplesPerPrompt", this.NumSamplesPerPrompt);
        }
    }
}

