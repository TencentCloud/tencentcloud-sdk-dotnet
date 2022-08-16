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

    public class CreateTrainingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 训练任务名称，不超过60个字符，仅支持中英文、数字、下划线"_"、短横"-"，只能以中英文、数字开头
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 训练模式，通过DescribeTrainingFrameworks接口查询，eg：PS_WORKER、DDP、MPI、HOROVOD
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// 计费模式，eg：PREPAID预付费，即包年包月；POSTPAID_BY_HOUR按小时后付费
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 资源配置，需填写对应算力规格ID和节点数量，算力规格ID查询接口为DescribeBillingSpecsPrice，eg：[{"Role":"WORKER", "InstanceType": "TI.S.MEDIUM.POST", "InstanceNum": 1}]
        /// </summary>
        [JsonProperty("ResourceConfigInfos")]
        public ResourceConfigInfo[] ResourceConfigInfos{ get; set; }

        /// <summary>
        /// COS代码包路径
        /// </summary>
        [JsonProperty("CodePackagePath")]
        public CosPathInfo CodePackagePath{ get; set; }

        /// <summary>
        /// COS训练输出路径
        /// </summary>
        [JsonProperty("Output")]
        public CosPathInfo Output{ get; set; }

        /// <summary>
        /// 是否上报日志
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 训练框架名称，通过DescribeTrainingFrameworks接口查询，eg：SPARK、PYSPARK、TENSORFLOW、PYTORCH
        /// </summary>
        [JsonProperty("FrameworkName")]
        public string FrameworkName{ get; set; }

        /// <summary>
        /// 训练框架版本，通过DescribeTrainingFrameworks接口查询，eg：tf1.15-py3.7-cpu、torch1.9-py3.8-cuda11.1-gpu
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// 预付费专用资源组ID，通过DescribeBillingResourceGroups接口查询
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 标签配置
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 自定义镜像信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 启动命令信息，默认为sh start.sh
        /// </summary>
        [JsonProperty("StartCmdInfo")]
        public StartCmdInfo StartCmdInfo{ get; set; }

        /// <summary>
        /// 数据来源，eg：DATASET、COS、CFS、HDFS
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// 数据配置
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

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
        /// CLS日志配置
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// 调优参数
        /// </summary>
        [JsonProperty("TuningParameters")]
        public string TuningParameters{ get; set; }

        /// <summary>
        /// 备注，最多500个字
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamArrayObj(map, prefix + "ResourceConfigInfos.", this.ResourceConfigInfos);
            this.SetParamObj(map, prefix + "CodePackagePath.", this.CodePackagePath);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "FrameworkName", this.FrameworkName);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "StartCmdInfo.", this.StartCmdInfo);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "TuningParameters", this.TuningParameters);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

