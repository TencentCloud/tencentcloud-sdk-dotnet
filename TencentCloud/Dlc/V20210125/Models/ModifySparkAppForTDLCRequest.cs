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

    public class ModifySparkAppForTDLCRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>spark作业名</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>spark作业类型，1代表spark jar作业，2代表spark streaming作业</p>
        /// </summary>
        [JsonProperty("AppType")]
        public long? AppType{ get; set; }

        /// <summary>
        /// <p>执行spark作业的数据引擎名称</p>
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// <p>spark作业程序包文件路径</p>
        /// </summary>
        [JsonProperty("AppFile")]
        public string AppFile{ get; set; }

        /// <summary>
        /// <p>数据访问策略，CAM Role arn</p>
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// <p>指定的Driver规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）</p>
        /// </summary>
        [JsonProperty("AppDriverSize")]
        public string AppDriverSize{ get; set; }

        /// <summary>
        /// <p>指定的Executor规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）</p>
        /// </summary>
        [JsonProperty("AppExecutorSize")]
        public string AppExecutorSize{ get; set; }

        /// <summary>
        /// <p>spark作业executor个数</p>
        /// </summary>
        [JsonProperty("AppExecutorNums")]
        public long? AppExecutorNums{ get; set; }

        /// <summary>
        /// <p>spark作业Id</p>
        /// </summary>
        [JsonProperty("SparkAppId")]
        public string SparkAppId{ get; set; }

        /// <summary>
        /// <p>该字段已下线，请使用字段Datasource</p>
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// <p>spark作业程序包是否本地上传，cos：存放与cos，lakefs：本地上传（控制台使用，该方式不支持直接接口调用）</p>
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// <p>spark作业主类</p>
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// <p>spark配置，以换行符分隔</p>
        /// </summary>
        [JsonProperty("AppConf")]
        public string AppConf{ get; set; }

        /// <summary>
        /// <p>spark 作业依赖jar包是否本地上传，cos：存放与cos，lakefs：本地上传（控制台使用，该方式不支持直接接口调用）</p>
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// <p>spark 作业依赖jar包（--jars），以逗号分隔</p>
        /// </summary>
        [JsonProperty("AppJars")]
        public string AppJars{ get; set; }

        /// <summary>
        /// <p>spark作业依赖文件资源是否本地上传，cos：存放与cos，lakefs：本地上传（控制台使用，该方式不支持直接接口调用）</p>
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// <p>spark作业依赖文件资源（--files）（非jar、zip），以逗号分隔</p>
        /// </summary>
        [JsonProperty("AppFiles")]
        public string AppFiles{ get; set; }

        /// <summary>
        /// <p>pyspark：依赖上传方式，cos：存放与cos，lakefs：本地上传（控制台使用，该方式不支持直接接口调用）</p>
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// <p>pyspark作业依赖python资源（--py-files），支持py/zip/egg等归档格式，多文件以逗号分隔</p>
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// <p>spark作业程序入参</p>
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// <p>最大重试次数，只对spark流任务生效</p>
        /// </summary>
        [JsonProperty("MaxRetries")]
        public long? MaxRetries{ get; set; }

        /// <summary>
        /// <p>数据源名</p>
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// <p>spark作业依赖archives资源是否本地上传，cos：存放与cos，lakefs：本地上传（控制台使用，该方式不支持直接接口调用）</p>
        /// </summary>
        [JsonProperty("IsLocalArchives")]
        public string IsLocalArchives{ get; set; }

        /// <summary>
        /// <p>spark作业依赖archives资源（--archives），支持tar.gz/tgz/tar等归档格式，以逗号分隔</p>
        /// </summary>
        [JsonProperty("AppArchives")]
        public string AppArchives{ get; set; }

        /// <summary>
        /// <p>Spark Image 版本号</p>
        /// </summary>
        [JsonProperty("SparkImage")]
        public string SparkImage{ get; set; }

        /// <summary>
        /// <p>Spark Image 版本名称</p>
        /// </summary>
        [JsonProperty("SparkImageVersion")]
        public string SparkImageVersion{ get; set; }

        /// <summary>
        /// <p>指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于AppExecutorNums</p>
        /// </summary>
        [JsonProperty("AppExecutorMaxNumbers")]
        public long? AppExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// <p>关联dlc查询脚本</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>任务资源配置是否继承集群配置模板：0（默认）不继承、1：继承</p>
        /// </summary>
        [JsonProperty("IsInherit")]
        public ulong? IsInherit{ get; set; }

        /// <summary>
        /// <p>是否使用session脚本的sql运行任务：false：否，true：是</p>
        /// </summary>
        [JsonProperty("IsSessionStarted")]
        public bool? IsSessionStarted{ get; set; }

        /// <summary>
        /// <p>标准引擎依赖包</p>
        /// </summary>
        [JsonProperty("DependencyPackages")]
        public DependencyPackage[] DependencyPackages{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsLocalArchives", this.IsLocalArchives);
            this.SetParamSimple(map, prefix + "AppArchives", this.AppArchives);
            this.SetParamSimple(map, prefix + "SparkImage", this.SparkImage);
            this.SetParamSimple(map, prefix + "SparkImageVersion", this.SparkImageVersion);
            this.SetParamSimple(map, prefix + "AppExecutorMaxNumbers", this.AppExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
            this.SetParamSimple(map, prefix + "IsSessionStarted", this.IsSessionStarted);
            this.SetParamArrayObj(map, prefix + "DependencyPackages.", this.DependencyPackages);
        }
    }
}

