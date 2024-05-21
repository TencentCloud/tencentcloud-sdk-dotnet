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

    public class ModifyModelServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 模型信息，需要挂载模型时填写
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

        /// <summary>
        /// 镜像信息，配置服务运行所需的镜像地址等信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 环境变量，可选参数，用于配置容器中的环境变量
        /// </summary>
        [JsonProperty("Env")]
        public EnvVar[] Env{ get; set; }

        /// <summary>
        /// 资源描述，指定预付费模式下的cpu,mem,gpu等信息，后付费无需填写
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceInfo Resources{ get; set; }

        /// <summary>
        /// 使用DescribeBillingSpecs接口返回的规格列表中的值，或者参考实例列表:
        /// TI.S.MEDIUM.POST	2C4G
        /// TI.S.LARGE.POST	4C8G
        /// TI.S.2XLARGE16.POST	8C16G
        /// TI.S.2XLARGE32.POST	8C32G
        /// TI.S.4XLARGE32.POST	16C32G
        /// TI.S.4XLARGE64.POST	16C64G
        /// TI.S.6XLARGE48.POST	24C48G
        /// TI.S.6XLARGE96.POST	24C96G
        /// TI.S.8XLARGE64.POST	32C64G
        /// TI.S.8XLARGE128.POST 32C128G
        /// TI.GN7.LARGE20.POST	4C20G T4*1/4
        /// TI.GN7.2XLARGE40.POST	10C40G T4*1/2
        /// TI.GN7.2XLARGE32.POST	8C32G T4*1
        /// TI.GN7.5XLARGE80.POST	20C80G T4*1
        /// TI.GN7.8XLARGE128.POST	32C128G T4*1
        /// TI.GN7.10XLARGE160.POST	40C160G T4*2
        /// TI.GN7.20XLARGE320.POST	80C320G T4*4
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 扩缩容类型 支持：自动 - "AUTO", 手动 - "MANUAL"
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// 实例数量, 不同计费模式和调节模式下对应关系如下
        /// PREPAID 和 POSTPAID_BY_HOUR:
        /// 手动调节模式下对应 实例数量
        /// 自动调节模式下对应 基于时间的默认策略的实例数量
        /// HYBRID_PAID:
        /// 后付费实例手动调节模式下对应 实例数量
        /// 后付费实例自动调节模式下对应 时间策略的默认策略的实例数量
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 自动伸缩信息
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscaler HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// 是否开启日志投递，开启后需填写配置投递到指定cls
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 日志配置，需要投递服务日志到指定cls时填写
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// 特殊更新行为： "STOP": 停止, "RESUME": 重启, "SCALE": 扩缩容, 存在这些特殊更新行为时，会忽略其他更新字段
        /// </summary>
        [JsonProperty("ServiceAction")]
        public string ServiceAction{ get; set; }

        /// <summary>
        /// 服务的描述
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// 自动伸缩策略
        /// </summary>
        [JsonProperty("ScaleStrategy")]
        public string ScaleStrategy{ get; set; }

        /// <summary>
        /// 自动伸缩策略配置 HPA : 通过HPA进行弹性伸缩 CRON 通过定时任务进行伸缩
        /// </summary>
        [JsonProperty("CronScaleJobs")]
        public CronScaleJob[] CronScaleJobs{ get; set; }

        /// <summary>
        /// 计费模式[HYBRID_PAID]时生效, 用于标识混合计费模式下的预付费实例数, 若不填则默认为1
        /// </summary>
        [JsonProperty("HybridBillingPrepaidReplicas")]
        public long? HybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// 是否开启模型的热更新。默认不开启
        /// </summary>
        [JsonProperty("ModelHotUpdateEnable")]
        public bool? ModelHotUpdateEnable{ get; set; }

        /// <summary>
        /// 定时停止配置
        /// </summary>
        [JsonProperty("ScheduledAction")]
        public ScheduledAction ScheduledAction{ get; set; }

        /// <summary>
        /// 服务限速限流相关配置
        /// </summary>
        [JsonProperty("ServiceLimit")]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// 挂载配置，目前只支持CFS
        /// </summary>
        [JsonProperty("VolumeMount")]
        public VolumeMount VolumeMount{ get; set; }

        /// <summary>
        /// 是否开启模型的加速, 仅对StableDiffusion(动态加速)格式的模型有效。默认不开启
        /// </summary>
        [JsonProperty("ModelTurboEnable")]
        public bool? ModelTurboEnable{ get; set; }

        /// <summary>
        /// 服务的启动命令，如遇特殊字符导致配置失败，可使用CommandBase64参数
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 是否开启TIONE内网访问外部，此功能仅支持后付费机型与从TIONE平台购买的预付费机型；使用从CVM选择资源组时此配置不生效。
        /// </summary>
        [JsonProperty("ServiceEIP")]
        public ServiceEIP ServiceEIP{ get; set; }

        /// <summary>
        /// 服务的启动命令，以base64格式进行输入，与Command同时配置时，仅当前参数生效
        /// </summary>
        [JsonProperty("CommandBase64")]
        public string CommandBase64{ get; set; }

        /// <summary>
        /// 服务端口，仅在非内置镜像时生效，默认8501。不支持输入8501-8510,6006,9092
        /// </summary>
        [JsonProperty("ServicePort")]
        public long? ServicePort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "ServiceAction", this.ServiceAction);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamSimple(map, prefix + "ScaleStrategy", this.ScaleStrategy);
            this.SetParamArrayObj(map, prefix + "CronScaleJobs.", this.CronScaleJobs);
            this.SetParamSimple(map, prefix + "HybridBillingPrepaidReplicas", this.HybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "ModelHotUpdateEnable", this.ModelHotUpdateEnable);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamObj(map, prefix + "VolumeMount.", this.VolumeMount);
            this.SetParamSimple(map, prefix + "ModelTurboEnable", this.ModelTurboEnable);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "ServiceEIP.", this.ServiceEIP);
            this.SetParamSimple(map, prefix + "CommandBase64", this.CommandBase64);
            this.SetParamSimple(map, prefix + "ServicePort", this.ServicePort);
        }
    }
}

