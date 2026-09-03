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

    public class TrainingTuningParams : AbstractModel
    {
        
        /// <summary>
        /// <p>微调方式：lora / full / freeze；默认由算法决定（SFT/DPO=lora，CPT/GRPO=full）</p>
        /// </summary>
        [JsonProperty("FineTuneType")]
        public string FineTuneType{ get; set; }

        /// <summary>
        /// <p>LoRA rank，仅 finetuneType=lora 时生效</p>
        /// </summary>
        [JsonProperty("LoraRank")]
        public long? LoraRank{ get; set; }

        /// <summary>
        /// <p>LoRA alpha</p>
        /// </summary>
        [JsonProperty("LoraAlpha")]
        public long? LoraAlpha{ get; set; }

        /// <summary>
        /// <p>LoRA dropout</p>
        /// </summary>
        [JsonProperty("LoraDropout")]
        public float? LoraDropout{ get; set; }

        /// <summary>
        /// <p>LoRA 目标层，默认 all</p>
        /// </summary>
        [JsonProperty("LoraTarget")]
        public string LoraTarget{ get; set; }

        /// <summary>
        /// <p>训练模式：balanced / quality / speed / custom</p>
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// <p>训练轮数</p>
        /// </summary>
        [JsonProperty("Epochs")]
        public long? Epochs{ get; set; }

        /// <summary>
        /// <p>学习率</p>
        /// </summary>
        [JsonProperty("LearningRate")]
        public float? LearningRate{ get; set; }

        /// <summary>
        /// <p>每卡 batch size</p>
        /// </summary>
        [JsonProperty("PerDeviceBatchSize")]
        public long? PerDeviceBatchSize{ get; set; }

        /// <summary>
        /// <p>梯度累积步数</p>
        /// </summary>
        [JsonProperty("GradientAccumulationSteps")]
        public long? GradientAccumulationSteps{ get; set; }

        /// <summary>
        /// <p>上下文长度</p>
        /// </summary>
        [JsonProperty("CutoffLen")]
        public long? CutoffLen{ get; set; }

        /// <summary>
        /// <p>最大样本数</p>
        /// </summary>
        [JsonProperty("MaxSamples")]
        public long? MaxSamples{ get; set; }

        /// <summary>
        /// <p>是否启用 gradient checkpointing，默认 true</p>
        /// </summary>
        [JsonProperty("GradientCheckPointing")]
        public bool? GradientCheckPointing{ get; set; }

        /// <summary>
        /// <p>学习率调度器类型，默认 cosine</p>
        /// </summary>
        [JsonProperty("LrScheduler")]
        public string LrScheduler{ get; set; }

        /// <summary>
        /// <p>warmup 比例，默认 0.03</p>
        /// </summary>
        [JsonProperty("WarmupRatio")]
        public float? WarmupRatio{ get; set; }

        /// <summary>
        /// <p>DPO beta，仅 mode=dpo 时生效</p>
        /// </summary>
        [JsonProperty("DPOBeta")]
        public float? DPOBeta{ get; set; }

        /// <summary>
        /// <p>DPO loss：sigmoid / hinge / ipo / kto_pair</p>
        /// </summary>
        [JsonProperty("DPOLoss")]
        public string DPOLoss{ get; set; }

        /// <summary>
        /// <p>兼容旧请求；当前 GRPO 默认使用 verl 内置 rule reward</p>
        /// </summary>
        [JsonProperty("RewardFunctionCode")]
        public string RewardFunctionCode{ get; set; }

        /// <summary>
        /// <p>兼容旧请求；当前 GRPO 默认使用 verl 内置 rule reward</p>
        /// </summary>
        [JsonProperty("RewardFunctionCosPath")]
        public string RewardFunctionCosPath{ get; set; }

        /// <summary>
        /// <p>GRPO KL 系数，默认 0.001</p>
        /// </summary>
        [JsonProperty("KLCoefficient")]
        public float? KLCoefficient{ get; set; }

        /// <summary>
        /// <p>每个 prompt 的采样数（group size），默认 8</p>
        /// </summary>
        [JsonProperty("NumSamplesPerPrompt")]
        public long? NumSamplesPerPrompt{ get; set; }

        /// <summary>
        /// <p>最大响应生成长度，默认 1024</p>
        /// </summary>
        [JsonProperty("MaxResponseLength")]
        public long? MaxResponseLength{ get; set; }

        /// <summary>
        /// <p>rollout 生成温度，默认 1.0</p>
        /// </summary>
        [JsonProperty("RollOutTemperature")]
        public float? RollOutTemperature{ get; set; }

        /// <summary>
        /// <p>rollout backend：vllm / sglang，默认 vllm</p>
        /// </summary>
        [JsonProperty("RollOutBackend")]
        public string RollOutBackend{ get; set; }

        /// <summary>
        /// <p>PPO clip ratio，默认 0.2</p>
        /// </summary>
        [JsonProperty("ClipRatio")]
        public float? ClipRatio{ get; set; }

        /// <summary>
        /// <p>PPO mini batch size，默认 128</p>
        /// </summary>
        [JsonProperty("PPOMiniBatchSize")]
        public long? PPOMiniBatchSize{ get; set; }

        /// <summary>
        /// <p>PPO epochs（每批数据的更新轮数），默认 1</p>
        /// </summary>
        [JsonProperty("PPOEpochs")]
        public long? PPOEpochs{ get; set; }

        /// <summary>
        /// <p>训练总 batch size（每步 prompt 数量），默认 128</p>
        /// </summary>
        [JsonProperty("TrainBatchSize")]
        public long? TrainBatchSize{ get; set; }

        /// <summary>
        /// <p>rollout tensor model parallel size，默认 1</p>
        /// </summary>
        [JsonProperty("TensorModelParallelSize")]
        public long? TensorModelParallelSize{ get; set; }

        /// <summary>
        /// <p>vLLM GPU memory utilization，默认 0.5</p>
        /// </summary>
        [JsonProperty("GpuMemoryUtilization")]
        public float? GpuMemoryUtilization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FineTuneType", this.FineTuneType);
            this.SetParamSimple(map, prefix + "LoraRank", this.LoraRank);
            this.SetParamSimple(map, prefix + "LoraAlpha", this.LoraAlpha);
            this.SetParamSimple(map, prefix + "LoraDropout", this.LoraDropout);
            this.SetParamSimple(map, prefix + "LoraTarget", this.LoraTarget);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamSimple(map, prefix + "Epochs", this.Epochs);
            this.SetParamSimple(map, prefix + "LearningRate", this.LearningRate);
            this.SetParamSimple(map, prefix + "PerDeviceBatchSize", this.PerDeviceBatchSize);
            this.SetParamSimple(map, prefix + "GradientAccumulationSteps", this.GradientAccumulationSteps);
            this.SetParamSimple(map, prefix + "CutoffLen", this.CutoffLen);
            this.SetParamSimple(map, prefix + "MaxSamples", this.MaxSamples);
            this.SetParamSimple(map, prefix + "GradientCheckPointing", this.GradientCheckPointing);
            this.SetParamSimple(map, prefix + "LrScheduler", this.LrScheduler);
            this.SetParamSimple(map, prefix + "WarmupRatio", this.WarmupRatio);
            this.SetParamSimple(map, prefix + "DPOBeta", this.DPOBeta);
            this.SetParamSimple(map, prefix + "DPOLoss", this.DPOLoss);
            this.SetParamSimple(map, prefix + "RewardFunctionCode", this.RewardFunctionCode);
            this.SetParamSimple(map, prefix + "RewardFunctionCosPath", this.RewardFunctionCosPath);
            this.SetParamSimple(map, prefix + "KLCoefficient", this.KLCoefficient);
            this.SetParamSimple(map, prefix + "NumSamplesPerPrompt", this.NumSamplesPerPrompt);
            this.SetParamSimple(map, prefix + "MaxResponseLength", this.MaxResponseLength);
            this.SetParamSimple(map, prefix + "RollOutTemperature", this.RollOutTemperature);
            this.SetParamSimple(map, prefix + "RollOutBackend", this.RollOutBackend);
            this.SetParamSimple(map, prefix + "ClipRatio", this.ClipRatio);
            this.SetParamSimple(map, prefix + "PPOMiniBatchSize", this.PPOMiniBatchSize);
            this.SetParamSimple(map, prefix + "PPOEpochs", this.PPOEpochs);
            this.SetParamSimple(map, prefix + "TrainBatchSize", this.TrainBatchSize);
            this.SetParamSimple(map, prefix + "TensorModelParallelSize", this.TensorModelParallelSize);
            this.SetParamSimple(map, prefix + "GpuMemoryUtilization", this.GpuMemoryUtilization);
        }
    }
}

