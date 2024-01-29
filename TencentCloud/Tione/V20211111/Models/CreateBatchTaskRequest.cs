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

    public class CreateBatchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量预测任务名称，不超过60个字符，仅支持中英文、数字、下划线"_"、短横"-"，只能以中英文、数字开头
        /// </summary>
        [JsonProperty("BatchTaskName")]
        public string BatchTaskName{ get; set; }

        /// <summary>
        /// 计费模式，eg：PREPAID 包年包月；POSTPAID_BY_HOUR 按量计费
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 资源配置
        /// </summary>
        [JsonProperty("ResourceConfigInfo")]
        public ResourceConfigInfo ResourceConfigInfo{ get; set; }

        /// <summary>
        /// 结果输出存储信息
        /// </summary>
        [JsonProperty("Outputs")]
        public DataConfig[] Outputs{ get; set; }

        /// <summary>
        /// 是否上报日志
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 工作类型 1:单次 2:周期
        /// </summary>
        [JsonProperty("JobType")]
        [System.Obsolete]
        public ulong? JobType{ get; set; }

        /// <summary>
        /// 任务周期描述
        /// </summary>
        [JsonProperty("CronInfo")]
        [System.Obsolete]
        public CronInfo CronInfo{ get; set; }

        /// <summary>
        /// 包年包月资源组ID
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 标签配置
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 服务对应的模型信息，有模型文件时需要填写
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

        /// <summary>
        /// 自定义镜像信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 代码包
        /// </summary>
        [JsonProperty("CodePackage")]
        public CosPathInfo CodePackage{ get; set; }

        /// <summary>
        /// 启动命令
        /// </summary>
        [JsonProperty("StartCmd")]
        public string StartCmd{ get; set; }

        /// <summary>
        /// 数据配置
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// 日志配置
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// VPC Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 任务执行结果回调URL，仅支持http和https。回调格式&内容详见: [TI-ONE 接口回调说明](https://cloud.tencent.com/document/product/851/84292)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchTaskName", this.BatchTaskName);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "ResourceConfigInfo.", this.ResourceConfigInfo);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "CronInfo.", this.CronInfo);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "CodePackage.", this.CodePackage);
            this.SetParamSimple(map, prefix + "StartCmd", this.StartCmd);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

