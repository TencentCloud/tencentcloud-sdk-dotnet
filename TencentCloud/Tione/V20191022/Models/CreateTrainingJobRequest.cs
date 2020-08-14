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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTrainingJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 算法镜像配置
        /// </summary>
        [JsonProperty("AlgorithmSpecification")]
        public AlgorithmSpecification AlgorithmSpecification{ get; set; }

        /// <summary>
        /// 输出数据配置
        /// </summary>
        [JsonProperty("OutputDataConfig")]
        public OutputDataConfig OutputDataConfig{ get; set; }

        /// <summary>
        /// 资源实例配置
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public ResourceConfig ResourceConfig{ get; set; }

        /// <summary>
        /// 训练任务名称
        /// </summary>
        [JsonProperty("TrainingJobName")]
        public string TrainingJobName{ get; set; }

        /// <summary>
        /// 输入数据配置
        /// </summary>
        [JsonProperty("InputDataConfig")]
        public InputDataConfig[] InputDataConfig{ get; set; }

        /// <summary>
        /// 中止条件
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition{ get; set; }

        /// <summary>
        /// 私有网络配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 算法超级参数
        /// </summary>
        [JsonProperty("HyperParameters")]
        public string HyperParameters{ get; set; }

        /// <summary>
        /// 环境变量配置
        /// </summary>
        [JsonProperty("EnvConfig")]
        public EnvConfig[] EnvConfig{ get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 在资源不足（ResourceInsufficient）时后台不定时尝试重新创建训练任务。可取值Enabled/Disabled
        /// 默认值为Disabled即不重新尝试。设为Enabled时重新尝试有一定的时间期限，定义在 StoppingCondition 中 MaxWaitTimeInSecond中 ，默认值为1天，超过该期限创建失败。
        /// </summary>
        [JsonProperty("RetryWhenResourceInsufficient")]
        public string RetryWhenResourceInsufficient{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AlgorithmSpecification.", this.AlgorithmSpecification);
            this.SetParamObj(map, prefix + "OutputDataConfig.", this.OutputDataConfig);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "TrainingJobName", this.TrainingJobName);
            this.SetParamArrayObj(map, prefix + "InputDataConfig.", this.InputDataConfig);
            this.SetParamObj(map, prefix + "StoppingCondition.", this.StoppingCondition);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "HyperParameters", this.HyperParameters);
            this.SetParamArrayObj(map, prefix + "EnvConfig.", this.EnvConfig);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RetryWhenResourceInsufficient", this.RetryWhenResourceInsufficient);
        }
    }
}

