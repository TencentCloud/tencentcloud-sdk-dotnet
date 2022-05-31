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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySparkAppRequest : AbstractModel
    {
        
        /// <summary>
        /// spark应用名
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 1代表spark jar应用，2代表spark streaming应用
        /// </summary>
        [JsonProperty("AppType")]
        public long? AppType{ get; set; }

        /// <summary>
        /// 执行spark作业的数据引擎
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// spark应用的执行入口
        /// </summary>
        [JsonProperty("AppFile")]
        public string AppFile{ get; set; }

        /// <summary>
        /// 执行spark作业的角色ID
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// spark作业driver资源规格大小, 可取small,medium,large,xlarge
        /// </summary>
        [JsonProperty("AppDriverSize")]
        public string AppDriverSize{ get; set; }

        /// <summary>
        /// spark作业executor资源规格大小, 可取small,medium,large,xlarge
        /// </summary>
        [JsonProperty("AppExecutorSize")]
        public string AppExecutorSize{ get; set; }

        /// <summary>
        /// spark作业executor个数
        /// </summary>
        [JsonProperty("AppExecutorNums")]
        public long? AppExecutorNums{ get; set; }

        /// <summary>
        /// spark应用Id
        /// </summary>
        [JsonProperty("SparkAppId")]
        public string SparkAppId{ get; set; }

        /// <summary>
        /// 该字段已下线，请使用字段Datasource
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// 是否本地上传，可取cos,lakefs
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// spark jar作业时的主类
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// spark配置，以换行符分隔
        /// </summary>
        [JsonProperty("AppConf")]
        public string AppConf{ get; set; }

        /// <summary>
        /// 是否本地上传，可去cos,lakefs
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// spark jar作业依赖jars，以逗号分隔
        /// </summary>
        [JsonProperty("AppJars")]
        public string AppJars{ get; set; }

        /// <summary>
        /// 是否本地上传，可去cos,lakefs
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// spark作业依赖资源，以逗号分隔
        /// </summary>
        [JsonProperty("AppFiles")]
        public string AppFiles{ get; set; }

        /// <summary>
        /// pyspark：依赖上传方式，1、cos；2、lakefs（控制台使用，该方式不支持直接接口调用）
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// pyspark：python依赖, 除py文件外，还支持zip/egg等归档格式，多文件以逗号分隔
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// spark作业命令行参数
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// 只对spark流任务生效
        /// </summary>
        [JsonProperty("MaxRetries")]
        public long? MaxRetries{ get; set; }

        /// <summary>
        /// 数据源名
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "DataEngine", this.DataEngine);
            this.SetParamSimple(map, prefix + "AppFile", this.AppFile);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "AppDriverSize", this.AppDriverSize);
            this.SetParamSimple(map, prefix + "AppExecutorSize", this.AppExecutorSize);
            this.SetParamSimple(map, prefix + "AppExecutorNums", this.AppExecutorNums);
            this.SetParamSimple(map, prefix + "SparkAppId", this.SparkAppId);
            this.SetParamSimple(map, prefix + "Eni", this.Eni);
            this.SetParamSimple(map, prefix + "IsLocal", this.IsLocal);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "AppConf", this.AppConf);
            this.SetParamSimple(map, prefix + "IsLocalJars", this.IsLocalJars);
            this.SetParamSimple(map, prefix + "AppJars", this.AppJars);
            this.SetParamSimple(map, prefix + "IsLocalFiles", this.IsLocalFiles);
            this.SetParamSimple(map, prefix + "AppFiles", this.AppFiles);
            this.SetParamSimple(map, prefix + "IsLocalPythonFiles", this.IsLocalPythonFiles);
            this.SetParamSimple(map, prefix + "AppPythonFiles", this.AppPythonFiles);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "MaxRetries", this.MaxRetries);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
        }
    }
}

