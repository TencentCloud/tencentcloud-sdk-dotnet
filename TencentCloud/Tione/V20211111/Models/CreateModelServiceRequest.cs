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

    public class CreateModelServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像信息，配置服务运行所需的镜像地址等信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 新增版本时需要填写
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// 不超过60个字，仅支持英文、数字、下划线"_"、短横"-"，只能以英文、数字开头
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// 模型服务的描述
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// 付费模式,有 PREPAID 、 POSTPAID_BY_HOUR 和 HYBRID_PAID 三种
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 预付费模式下所属的资源组id，同服务组下唯一
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 模型信息，需要挂载模型时填写
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

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
        /// 扩缩容类型 支持：自动 - "AUTO", 手动 - "MANUAL",默认为MANUAL
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
        /// 是否开启接口鉴权，开启后自动生成token信息，访问需要token鉴权
        /// </summary>
        [JsonProperty("AuthorizationEnable")]
        public bool? AuthorizationEnable{ get; set; }

        /// <summary>
        /// 腾讯云标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否新增版本
        /// </summary>
        [JsonProperty("NewVersion")]
        public bool? NewVersion{ get; set; }

        /// <summary>
        /// 定时任务配置，使用定时策略时填写
        /// </summary>
        [JsonProperty("CronScaleJobs")]
        public CronScaleJob[] CronScaleJobs{ get; set; }

        /// <summary>
        /// 自动伸缩策略配置 HPA : 通过HPA进行弹性伸缩 CRON 通过定时任务进行伸缩
        /// </summary>
        [JsonProperty("ScaleStrategy")]
        public string ScaleStrategy{ get; set; }

        /// <summary>
        /// 计费模式[HYBRID_PAID]时生效, 用于标识混合计费模式下的预付费实例数
        /// </summary>
        [JsonProperty("HybridBillingPrepaidReplicas")]
        public long? HybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// [AUTO_ML 自动学习，自动学习正式发布 AUTO_ML_FORMAL, DEFAULT 默认]
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

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
        /// 挂载配置，目前只支持CFS
        /// </summary>
        [JsonProperty("VolumeMount")]
        public VolumeMount VolumeMount{ get; set; }

        /// <summary>
        /// 服务限速限流相关配置
        /// </summary>
        [JsonProperty("ServiceLimit")]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// 回调地址，用于回调创建服务状态信息，回调格式&内容详情见：[TI-ONE 接口回调说明](https://cloud.tencent.com/document/product/851/84292)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "AuthorizationEnable", this.AuthorizationEnable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NewVersion", this.NewVersion);
            this.SetParamArrayObj(map, prefix + "CronScaleJobs.", this.CronScaleJobs);
            this.SetParamSimple(map, prefix + "ScaleStrategy", this.ScaleStrategy);
            this.SetParamSimple(map, prefix + "HybridBillingPrepaidReplicas", this.HybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "ModelHotUpdateEnable", this.ModelHotUpdateEnable);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
            this.SetParamObj(map, prefix + "VolumeMount.", this.VolumeMount);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

