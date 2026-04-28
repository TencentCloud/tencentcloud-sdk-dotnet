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

    public class CreateTrainingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>训练任务名称，不超过60个字符，仅支持中英文、数字、下划线&quot;_&quot;、短横&quot;-&quot;，只能以中英文、数字开头</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>计费模式，eg：PREPAID 包年包月（资源组）;<br>POSTPAID_BY_HOUR 按量计费</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>资源配置，需填写对应算力规格ID和节点数量，算力规格ID查询接口为DescribeBillingSpecsPrice，eg：[{&quot;Role&quot;:&quot;WORKER&quot;, &quot;InstanceType&quot;: &quot;TI.S.MEDIUM.POST&quot;, &quot;InstanceNum&quot;: 1}]</p>
        /// </summary>
        [JsonProperty("ResourceConfigInfos")]
        public ResourceConfigInfo[] ResourceConfigInfos{ get; set; }

        /// <summary>
        /// <p>TI工作空间ID</p><p>仅用于“工作空间”白名单功能。如需使用，请联系TI管理员开通白名单。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>训练框架名称，通过DescribeTrainingFrameworks接口查询，eg：SPARK、PYSPARK、TENSORFLOW、PYTORCH</p>
        /// </summary>
        [JsonProperty("FrameworkName")]
        public string FrameworkName{ get; set; }

        /// <summary>
        /// <p>训练框架版本，通过DescribeTrainingFrameworks接口查询，eg：1.15、1.9</p>
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// <p>训练框架环境，通过DescribeTrainingFrameworks接口查询，eg：tf1.15-py3.7-cpu、torch1.9-py3.8-cuda11.1-gpu</p>
        /// </summary>
        [JsonProperty("FrameworkEnvironment")]
        public string FrameworkEnvironment{ get; set; }

        /// <summary>
        /// <p>预付费专用资源组ID，通过DescribeBillingResourceGroups接口查询</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>标签配置</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自定义镜像信息</p>
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// <p>COS代码包路径</p>
        /// </summary>
        [JsonProperty("CodePackagePath")]
        public CosPathInfo CodePackagePath{ get; set; }

        /// <summary>
        /// <p>任务的启动命令，按任务训练模式输入，如遇特殊字符导致配置失败，可使用EncodedStartCmdInfo参数</p>
        /// </summary>
        [JsonProperty("StartCmdInfo")]
        public StartCmdInfo StartCmdInfo{ get; set; }

        /// <summary>
        /// <p>训练模式，通过DescribeTrainingFrameworks接口查询，eg：PS_WORKER、DDP、MPI、HOROVOD</p>
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// <p>数据配置，依赖DataSource字段，数量不超过10个</p>
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// <p>VPC Id</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网Id</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>COS训练输出路径</p>
        /// </summary>
        [JsonProperty("Output")]
        public CosPathInfo Output{ get; set; }

        /// <summary>
        /// <p>CLS日志配置</p>
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// <p>调优参数，不超过2048个字符</p>
        /// </summary>
        [JsonProperty("TuningParameters")]
        public string TuningParameters{ get; set; }

        /// <summary>
        /// <p>是否上报日志</p>
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// <p>备注，不超过1024个字符</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>数据来源，eg：DATASET、COS、CFS、CFSTurbo、HDFS、GooseFSx</p>
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// <p>回调地址，用于创建/启动/停止训练任务的异步回调。回调格式&amp;内容详见：<a href="https://cloud.tencent.com/document/product/851/84292">[TI-ONE接口回调说明]</a></p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>编码后的任务启动命令，与StartCmdInfo同时配置时，仅当前参数生效</p>
        /// </summary>
        [JsonProperty("EncodedStartCmdInfo")]
        public EncodedStartCmdInfo EncodedStartCmdInfo{ get; set; }

        /// <summary>
        /// <p>代码仓库配置</p>
        /// </summary>
        [JsonProperty("CodeRepos")]
        public CodeRepoConfig[] CodeRepos{ get; set; }

        /// <summary>
        /// <p>网络暴露配置</p>
        /// </summary>
        [JsonProperty("ExposeNetworkConfig")]
        public ExposeNetworkConfig ExposeNetworkConfig{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// </summary>
        [JsonProperty("Envs")]
        public EnvVar[] Envs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamArrayObj(map, prefix + "ResourceConfigInfos.", this.ResourceConfigInfos);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "FrameworkName", this.FrameworkName);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamSimple(map, prefix + "FrameworkEnvironment", this.FrameworkEnvironment);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "CodePackagePath.", this.CodePackagePath);
            this.SetParamObj(map, prefix + "StartCmdInfo.", this.StartCmdInfo);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "TuningParameters", this.TuningParameters);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "EncodedStartCmdInfo.", this.EncodedStartCmdInfo);
            this.SetParamArrayObj(map, prefix + "CodeRepos.", this.CodeRepos);
            this.SetParamObj(map, prefix + "ExposeNetworkConfig.", this.ExposeNetworkConfig);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
        }
    }
}

