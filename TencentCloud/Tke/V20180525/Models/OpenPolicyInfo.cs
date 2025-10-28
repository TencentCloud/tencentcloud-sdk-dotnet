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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略分类：cluster集群策略、node节点策略、namespace命名空间策略、configuration配置相关策略、compute计算资源策略、storage存储资源策略、network网络资源策略
        /// </summary>
        [JsonProperty("PolicyCategory")]
        public string PolicyCategory{ get; set; }

        /// <summary>
        /// 策略中文名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("PolicyDesc")]
        public string PolicyDesc{ get; set; }

        /// <summary>
        /// 策略运行模式：dryrun空跑不生效，deny拦截生效
        /// </summary>
        [JsonProperty("EnforcementAction")]
        public string EnforcementAction{ get; set; }

        /// <summary>
        /// 关联的事件数量(最近7d)
        /// </summary>
        [JsonProperty("EventNums")]
        public ulong? EventNums{ get; set; }

        /// <summary>
        /// 策略英文名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 策略模板类型，支持的类型如下：
        /// 优选策略：
        /// blocknamespacedeletion：存在pod的命名空间不允许删除
        /// blockcrddeletion：存在cr的crd不允许删除
        /// blockmountablevolumetype：禁止挂载指定的volume类型
        /// disallowalwayspullimage：禁止镜像拉取策略使用Always
        /// tkeallowedrepos：容器镜像来源限制
        /// blockunknowndaemonset：禁止未知的DaemonSet部署
        /// blockpvdeletion：PV处于绑定状态则不允许删除
        /// corednsprotect：CoreDNS组件删除保护
        /// blockschedulablenodedelete：非封锁状态的Node不允许删除
        /// resourcesdeletionprotection：资源删除保护
        /// tkeenirequest：弹性网卡资源配置限制
        /// blockworkloadcrossversionupgrade：工作负载镜像版本升级策略管控
        /// blockserviceaccountgranthighprivilegepermission：ServiceAccount权限管控
        /// blockclusteripserviceexist：不允许Service为ClusterIP类型
        /// blockinternetaccess：禁止公网访问
        /// assign：禁止访问Metadata Server
        /// blockhostnetworkpod：禁止创建HostNetwork类型Pod
        /// 
        /// 可选策略：
        /// blockvolumemountpath：禁止容器挂载指定的目录
        /// k8sallowedrepos：容器镜像必须以指定字符串列表中的字符串开头
        /// k8sblockendpointeditdefaultrole：禁止默认ClusterRole修改Endpoints
        /// k8sblockloadbalancer：不允许Service为LoadBalancer类型
        /// k8sblocknodeport：不允许Service为NodePort类型
        /// k8sblockwildcardingress：禁止ingress配置空白或通配符类型的hostname
        /// k8scontainerlimits：限制容器必须设置CPU和内存Limit
        /// k8scontainerratios：限制CPU和内存的Request与Limit的最大比率
        /// k8scontainerrequests：限制CPU和内存的Request必须设置且小于配置的最大值
        /// k8srequiredresources：必须配置内存的Limit，CPU和内存的Request
        /// k8sdisallowanonymous：不允许将白名单以外的ClusterRole和Role关联到system:anonymous User和system:unauthenticated Group
        /// k8sdisallowedtags：约束容器镜像tag
        /// k8sexternalips：限制服务externalIP仅为允许的IP地址列表
        /// k8simagedigests：容器镜像必须包含digest
        /// noupdateserviceaccount：拒绝白名单外的资源更新ServiceAccount
        /// k8sreplicalimits：要求具有spec.replicas字段的对象（Deployments、ReplicaSets等）在定义的范围内
        /// k8srequiredannotations：要求资源包含指定的annotations，其值与提供的正则表达式匹配
        /// k8srequiredlabels：要求资源包含指定的标签，其值与提供的正则表达式匹配
        /// k8srequiredprobes：要求Pod具有Readiness或Liveness Probe
        /// k8spspautomountserviceaccounttokenpod：约束容器不能设置automountServiceAccountToken为true
        /// k8spspallowprivilegeescalationcontainer：约束PodSecurityPolicy中的allowPrivilegeEscalation字段为false
        /// k8spspapparmor：约束AppArmor字段列表
        /// k8spspcapabilities：限制PodSecurityPolicy中的allowedCapabilities和requiredDropCapabilities字段
        /// k8spspflexvolumes：约束PodSecurityPolicy中的allowedFlexVolumes字段类型
        /// k8spspforbiddensysctls：约束PodSecurityPolicy中的sysctls字段不能使用的name
        /// k8spspfsgroup：控制PodSecurityPolicy中的fsGroup字段在限制范围内
        /// k8spsphostfilesystem：约束PodSecurityPolicy中的hostPath字段的参数
        /// k8spsphostnamespace：限制PodSecurityPolicy中的hostPID和hostIPC字段
        /// k8spsphostnetworkingports：约束PodSecurityPolicy中的hostNetwork和hostPorts字段
        /// k8spspprivilegedcontainer：禁止PodSecurityPolicy中的privileged字段为true
        /// k8spspprocmount：约束PodSecurityPolicy中的allowedProcMountTypes字段
        /// k8spspreadonlyrootfilesystem：约束PodSecurityPolicy中的readOnlyRootFilesystem字段
        /// k8spspseccomp：约束PodSecurityPolicy上的seccomp.security.alpha.kubernetes.io/allowedProfileNames注解
        /// k8spspselinuxv2：约束Pod定义SELinux配置的允许列表
        /// k8spspallowedusers：约束PodSecurityPolicy中的runAsUser、runAsGroup、supplementalGroups和fsGroup字段
        /// k8spspvolumetypes：约束PodSecurityPolicy中的volumes字段类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 策略开关状态：open打开，close关闭
        /// </summary>
        [JsonProperty("EnabledStatus")]
        public string EnabledStatus{ get; set; }

        /// <summary>
        /// 策略的实例的yaml示例base64编码
        /// </summary>
        [JsonProperty("ConstraintYamlExample")]
        public string ConstraintYamlExample{ get; set; }

        /// <summary>
        /// 策略关联的实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenConstraintInfoList")]
        public OpenConstraintInfo[] OpenConstraintInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyCategory", this.PolicyCategory);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyDesc", this.PolicyDesc);
            this.SetParamSimple(map, prefix + "EnforcementAction", this.EnforcementAction);
            this.SetParamSimple(map, prefix + "EventNums", this.EventNums);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "EnabledStatus", this.EnabledStatus);
            this.SetParamSimple(map, prefix + "ConstraintYamlExample", this.ConstraintYamlExample);
            this.SetParamArrayObj(map, prefix + "OpenConstraintInfoList.", this.OpenConstraintInfoList);
        }
    }
}

